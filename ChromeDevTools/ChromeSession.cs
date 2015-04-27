using ChromeDevTools.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace ChromeDevTools
{
    public class ChromeSession : IChromeSession
    {
        private readonly string _endpoint;
        private readonly ConcurrentDictionary<string, ConcurrentBag<EventHandler>> _handlers = new ConcurrentDictionary<string, ConcurrentBag<EventHandler>>();
        private ICommandFactory _commandFactory;
        private IEventFactory _eventFactory;
        private ManualResetEvent _openEvent = new ManualResetEvent(false);
        private ManualResetEvent _publishEvent = new ManualResetEvent(false);
        private ConcurrentDictionary<long, ManualResetEvent> _requestWaitHandles = new ConcurrentDictionary<long, ManualResetEvent>();
        private ICommandResponseFactory _responseFactory;
        private ConcurrentDictionary<long, ICommandResponse> _responses = new ConcurrentDictionary<long, ICommandResponse>();
        private WebSocket _webSocket;
        private static object _Lock = new object();

        public ChromeSession(string endpoint, ICommandFactory commandFactory, ICommandResponseFactory responseFactory, IEventFactory eventFactory)
        {
            _endpoint = endpoint;
            _commandFactory = commandFactory;
            _responseFactory = responseFactory;
            _eventFactory = eventFactory;
        }

        public void Dispose()
        {
            if (null == _webSocket) return;
            if (_webSocket.State == WebSocketState.Open)
            {
                _webSocket.Close();
            }
            _webSocket.Dispose();
        }

        private void EnsureInit()
        {
            if(null == _webSocket)
            {
                lock(_Lock)
                {
                    if(null == _webSocket)
                    {
                        Init().Wait();
                    }
                }
            }
        }

        private Task Init()
        {
            _openEvent.Reset();

            _webSocket = new WebSocket(_endpoint);
            _webSocket.Opened += WebSocket_Opened;
            _webSocket.MessageReceived += WebSocket_MessageReceived;
            _webSocket.Error += WebSocket_Error;
            _webSocket.Closed += WebSocket_Closed;
            _webSocket.DataReceived += WebSocket_DataReceived;

            _webSocket.Open();
            return Task.Run(() =>
            {
                _openEvent.WaitOne();
            });
        }


        public Task<ICommandResponse> SendAsync<T>()
        {
            var command = _commandFactory.Create<T>();
            return SendCommand(command);
        }

        public Task<ICommandResponse> SendAsync<T>(T parameter)
        {
            var command = _commandFactory.Create(parameter);
            return SendCommand(command);
        }

        public void Subscribe<T>(EventHandler handler)
        {
            var handlerType = typeof(T);
            _handlers.AddOrUpdate(handlerType.FullName,
                (m) => new ConcurrentBag<EventHandler>(new[] { handler }),
                (m, currentBag) =>
                {
                    currentBag.Add(handler);
                    return currentBag;
                });
        }

        private void HandleEvent(IEvent evnt)
        {
            if (null == evnt
                || null == evnt)
            {
                return;
            }
            var type = evnt.GetType().GetGenericArguments().FirstOrDefault();
            if (null == type)
            {
                return;
            }
            var handlerKey = type.FullName;
            ConcurrentBag<EventHandler> handlers = null;
            if (_handlers.TryGetValue(handlerKey, out handlers))
            {
                var localHandlers = handlers.ToArray();
                foreach (var handler in localHandlers)
                {
                    handler(this, evnt);
                }
            }
        }

        private void HandleResponse(ICommandResponse response)
        {
            if (null == response) return;
            ManualResetEvent requestMre;
            if (_requestWaitHandles.TryGetValue(response.Id, out requestMre))
            {
                _responses.AddOrUpdate(response.Id, id => response, (key, value) => response);
                requestMre.Set();
            }
            else
            {
                // in the case of an error, we don't always get the request Id back :(
                // if there is only one pending requests, we know what to do ... otherwise
                if (1 == _requestWaitHandles.Count)
                {
                    var requestId = _requestWaitHandles.Keys.First();
                    _requestWaitHandles.TryGetValue(requestId, out requestMre);
                    _responses.AddOrUpdate(requestId, id => response, (key, value) => response);
                    requestMre.Set();
                }
            }
        }

        private Task<ICommandResponse> SendCommand(Command command)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new MessageContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
            };
            var requestString = JsonConvert.SerializeObject(command, settings);
            var requestResetEvent = new ManualResetEvent(false);
            _requestWaitHandles.AddOrUpdate(command.Id, requestResetEvent, (id, r) => requestResetEvent);
            return Task.Run(() =>
            {
                EnsureInit();            
                _webSocket.Send(requestString);
                requestResetEvent.WaitOne();
                ICommandResponse response = null;
                _responses.TryRemove(command.Id, out response);
                _requestWaitHandles.TryRemove(command.Id, out requestResetEvent);
                return response;
            });
        }
        private bool TryGetCommandResponse(byte[] data, out ICommandResponse response)
        {
            response = _responseFactory.Create(data);
            return null != response;
        }

        private bool TryGetCommandResponse(string message, out ICommandResponse response)
        {
            response = _responseFactory.Create(message);
            return null != response;
        }

        private bool TryGetEvent(byte[] data, out IEvent evnt)
        {
            evnt = _eventFactory.Create(data);
            return null != evnt;
        }

        private bool TryGetEvent(string message, out IEvent evnt)
        {
            evnt = _eventFactory.Create(message);
            return null != evnt;
        }

        private void WebSocket_Closed(object sender, EventArgs e)
        {
        }

        private void WebSocket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            ICommandResponse response;
            if (TryGetCommandResponse(e.Data, out response))
            {
                HandleResponse(response);
                return;
            }
            IEvent evnt;
            if (TryGetEvent(e.Data, out evnt))
            {
                HandleEvent(evnt);
                return;
            }
            throw new Exception("Don't know what to do with response: " + e.Data);
        }

        private void WebSocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            throw e.Exception;
        }

        private void WebSocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            ICommandResponse response;
            if (TryGetCommandResponse(e.Message, out response))
            {
                HandleResponse(response);
                return;
            }
            IEvent evnt;
            if (TryGetEvent(e.Message, out evnt))
            {
                HandleEvent(evnt);
                return;
            }
            throw new Exception("Don't know what to do with response: " + e.Message);
        }

        private void WebSocket_Opened(object sender, EventArgs e)
        {
            _openEvent.Set();
        }
    }
}