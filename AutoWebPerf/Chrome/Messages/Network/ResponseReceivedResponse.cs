using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages.Network
{
    [MethodName(MethodName.Network.ResponseReceived)]
    public class ResponseReceivedResponse : IResponse
    {
        public string method { get; set; }
        public ResponseReceivedResponseParams Params { get; set; }
    }

    public class ResponseReceivedResponseParams
    {
        public string requestId { get; set; }
        public string frameId { get; set; }
        public string loaderId { get; set; }
        public float timestamp { get; set; }
        public string type { get; set; }
        public Response response { get; set; }
    }

    public class Response
    {
        public string url { get; set; }
        public int status { get; set; }
        public string statusText { get; set; }
        public ResponseHeaders headers { get; set; }
        public string mimeType { get; set; }
        public bool connectionReused { get; set; }
        public int connectionId { get; set; }
        public int encodedDataLength { get; set; }
        public bool fromDiskCache { get; set; }
        public bool fromServiceWorker { get; set; }
        public Timing timing { get; set; }
        public string headersText { get; set; }
        public Requestheaders requestHeaders { get; set; }
        public string requestHeadersText { get; set; }
        public string remoteIPAddress { get; set; }
        public int remotePort { get; set; }
        public string protocol { get; set; }
    }

    public class ResponseHeaders
    {
        public string Date { get; set; }
        public string ContentEncoding { get; set; }
        public string Server { get; set; }
        public string XAspNetVersion { get; set; }
        public string XPoweredBy { get; set; }
        public string Vary { get; set; }
        public string ContentType { get; set; }
        public string accesscontrolalloworigin { get; set; }
        public string CacheControl { get; set; }
        public string SetCookie { get; set; }
        public string accesscontrolallowheaders { get; set; }
        public string ContentLength { get; set; }
        public string Expires { get; set; }
    }

    public class Timing
    {
        public float requestTime { get; set; }
        public int proxyStart { get; set; }
        public int proxyEnd { get; set; }
        public int dnsStart { get; set; }
        public int dnsEnd { get; set; }
        public int connectStart { get; set; }
        public int connectEnd { get; set; }
        public int sslStart { get; set; }
        public int sslEnd { get; set; }
        public int serviceWorkerFetchStart { get; set; }
        public int serviceWorkerFetchReady { get; set; }
        public int serviceWorkerFetchEnd { get; set; }
        public float sendStart { get; set; }
        public float sendEnd { get; set; }
        public float receiveHeadersEnd { get; set; }
    }

    public class Requestheaders
    {
        public string Accept { get; set; }
        public string Connection { get; set; }
        public string AcceptEncoding { get; set; }
        public string Host { get; set; }
        public string AcceptLanguage { get; set; }
        public string UserAgent { get; set; }
    }

}
