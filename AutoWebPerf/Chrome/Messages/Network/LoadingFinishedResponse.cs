using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages.Network
{

    [MethodName(MethodName.Network.LoadingFinished)]
    public class LoadingFinishedResponse : IResponse
    {
        public string method { get; set; }
        public LoadingFinishedResponseParams Params { get; set; }
    }

    public class LoadingFinishedResponseParams
    {
        public string requestId { get; set; }
        public float timestamp { get; set; }
        public int encodedDataLength { get; set; }
    }

}
