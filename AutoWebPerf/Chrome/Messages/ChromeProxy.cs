using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace AutoWebPerf.Chrome.Messages
{
    class ChromeProxy : IChromeProxy
    {
        private ManualResetEvent _openEvent = new ManualResetEvent(false);
        private ManualResetEvent _publishEvent = new ManualResetEvent(false);
        private readonly string _endpoint;
        private WebSocket _webSocket;
        private readonly ConcurrentDictionary<string, ConcurrentBag<ResponseHandler>> _handlers = new ConcurrentDictionary<string, ConcurrentBag<ResponseHandler>>();
        private IResponseFactory _responseFactory;
        private ConcurrentDictionary<long, ManualResetEvent> _requestWaitHandles = new ConcurrentDictionary<long, ManualResetEvent>();
        private ConcurrentDictionary<long, IResponse> _responses = new ConcurrentDictionary<long, IResponse>();

        public ChromeProxy(string endpoint, IResponseFactory responseFactory)
        {
            _endpoint = endpoint;
            _responseFactory = responseFactory;
        }

        public Task Init()
        {
            _openEvent.Reset();
            _webSocket = new WebSocket(_endpoint);
            _webSocket.Opened += delegate(System.Object o, EventArgs e)
            {
                _openEvent.Set();
            };

            _webSocket.MessageReceived += delegate(System.Object o, MessageReceivedEventArgs e)
            {
                var response = _responseFactory.Create(e.Message);
                var idResponse = response as IdResponse;
                ManualResetEvent requestMre = null;
                long responseId;
                if (null != idResponse 
                    && long.TryParse(idResponse.Id, out responseId)
                    && _requestWaitHandles.TryGetValue(responseId, out requestMre))
                {
                    _responses.AddOrUpdate(responseId, response, (i, r) => response);
                    requestMre.Set();
                }
                else
                {
                    HandleResponse(response);
                }
            };

            _webSocket.Error += delegate(System.Object o, SuperSocket.ClientEngine.ErrorEventArgs e)
            {
                throw e.Exception;
            };

            _webSocket.Closed += delegate(System.Object o, EventArgs e)
            {
            };

            _webSocket.DataReceived += delegate(System.Object o, WebSocket4Net.DataReceivedEventArgs e)
            {
                var response = _responseFactory.Create(e.Data);
                HandleResponse(response);
            };

            _webSocket.Open();
            return Task.Run(() =>
            {
                _openEvent.WaitOne();
            });
        }

        private void HandleResponse(IResponse response)
        {
            var type = response.GetType();
            var handlerKey = type.FullName;
            ConcurrentBag<ResponseHandler> handlers = null;
            if(_handlers.TryGetValue(handlerKey, out handlers))
            {
                var localHandlers = handlers.ToArray();
                foreach(var handler in localHandlers)
                {
                    handler(this, response);
                }
            }
        }

        public Task<IResponse> PublishAsync(IRequest request)
        {
            var settings = new JsonSerializerSettings 
            {
                ContractResolver = new MessageContractResolver()
            };
            var requestString = JsonConvert.SerializeObject(request, settings);

            var requestResetEvent = new ManualResetEvent(false);
            _requestWaitHandles.AddOrUpdate(request.Id, requestResetEvent, (id, r) => requestResetEvent);
            return Task.Run(() =>
                {
                    _webSocket.Send(requestString);
                    requestResetEvent.WaitOne();
                    IResponse response = null;
                    _requestWaitHandles.TryRemove(request.Id, out requestResetEvent);
                    _responses.TryRemove(request.Id, out response);
                    return response;
                });
        }

        public void Subscribe<T>(ResponseHandler handler)
        {
            var handlerType = typeof(T);
            _handlers.AddOrUpdate(handlerType.FullName, 
                (m) => new ConcurrentBag<ResponseHandler>(new[] { handler }),
                (m, currentBag) => 
                {
                    currentBag.Add(handler);
                    return currentBag;
                });
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
    }
}
