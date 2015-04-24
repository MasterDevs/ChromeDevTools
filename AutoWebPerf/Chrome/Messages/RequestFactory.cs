using AutoWebPerf.Chrome.Messages.Page;
using System;
using System.Collections.Concurrent;
using System.Threading;

namespace AutoWebPerf.Chrome.Messages
{
    internal class RequestFactory : IRequestFactory
    {
        private readonly ConcurrentDictionary<long, string> _methods = new ConcurrentDictionary<long, string>();
        private long _count = 0;
        public NavigateRequest CreateNavigateRequest(string url)
        {
            return CreateRequest(id =>
                {
                    var requestParams = new NavigateRequestParams
                    {
                        Url = url
                    };
                    return new NavigateRequest(id, requestParams);
                });
        }

        public Network.EnableRequest CreateNetworkEnableRequest()
        {
            return CreateRequest(id => new Network.EnableRequest(id));
        }

        public string GetMethod(long id)
        {
            return _methods[id];
        }

        private T CreateRequest<T>(Func<long, T> factory) where T : IRequest
        {
            var requestId = GetNextRequestId();
            var request = factory(requestId);
            _methods.AddOrUpdate(request.Id, request.Method, (id, m) => request.Method);
            return request;
        }

        private long GetNextRequestId()
        {
            return Interlocked.Increment(ref _count);
        }
    }
}