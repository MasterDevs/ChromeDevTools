using AutoWebPerf.Chrome.Messages.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages
{
    interface IRequestFactory
    {
        string GetMethod(long id);

        
        NavigateRequest CreateNavigateRequest(string url);

        Network.EnableRequest CreateNetworkEnableRequest();
    }
}
