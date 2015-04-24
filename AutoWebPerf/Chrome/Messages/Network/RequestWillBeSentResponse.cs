using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages.Network
{
    [MethodName(MethodName.Network.RequestWillBeSent)]
    public class RequestWillBeSentResponse : IResponse
    {
        public string method { get; set; }
        public RequestWillBeSentResponseParams Params { get; set; }
    }

    public class RequestWillBeSentResponseParams
    {
        public string requestId { get; set; }
        public string frameId { get; set; }
        public string loaderId { get; set; }
        public string documentURL { get; set; }
        public Request request { get; set; }
        public float timestamp { get; set; }
        public Initiator initiator { get; set; }
        public string type { get; set; }
    }

    public class Request
    {
        public string url { get; set; }
        public string method { get; set; }
        public RequestHeaders headers { get; set; }
    }

    public class RequestHeaders
    {
        public string Accept { get; set; }
        public string UserAgent { get; set; }
    }

    public class Initiator
    {
        public string type { get; set; }
    }

}
