using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages
{
    public static class MethodName
    {
        public static class Network
        {
            public const string DataReceived = "Network.dataReceived";
            public const string Enable = "Network.enable";
            public const string LoadingFinished = "Network.loadingFinished";
            public const string RequestWillBeSent = "Network.requestWillBeSent";
            public const string ResponseReceived = "Network.responseReceived";
            public const string RequestServedFromCache = "Network.requestServedFromCache";
        }
        public static class Page
        {
            public const string Navigate = "Page.navigate";
        }
    }
}
