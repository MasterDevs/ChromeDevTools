using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf
{
    [Serializable]
    [DataContract]
    public class RemoteSessionsResponse
    {
        public RemoteSessionsResponse() { }

        [DataMember]
        public string devtoolsFrontendUrl;

        [DataMember]
        public string faviconUrl;

        [DataMember]
        public string thumbnailUrl;

        [DataMember]
        public string title;

        [DataMember]
        public string url;

        [DataMember]
        public string webSocketDebuggerUrl;
    }
}
