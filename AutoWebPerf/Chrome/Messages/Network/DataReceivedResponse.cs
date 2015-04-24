using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages.Network
{
    [MethodName(MethodName.Network.DataReceived)]
    public class DataReceivedResponse : IResponse
    {
        public string method { get; set; }
        public DataReceivedResponseParams Params { get; set; }
    }

    public class DataReceivedResponseParams
    {
        public string requestId { get; set; }
        public float timestamp { get; set; }
        public int dataLength { get; set; }
        public int encodedDataLength { get; set; }
    }

}
