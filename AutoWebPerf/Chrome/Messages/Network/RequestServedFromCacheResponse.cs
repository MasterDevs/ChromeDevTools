using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages.Network
{
    [MethodName(MethodName.Network.RequestServedFromCache)]
    public class RequestServedFromCacheResponse : IResponse
    {
        public string method { get; set; }
        public RequestServedFromCacheResponseParams Params { get; set; }
    }

    public class RequestServedFromCacheResponseParams
    {
        public string requestId { get; set; }
    }

}
