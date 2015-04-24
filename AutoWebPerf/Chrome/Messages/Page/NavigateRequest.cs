using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages.Page
{
    [MethodName("Page.navigate")]
    class NavigateRequest : Request<NavigateRequestParams>
    {
        public NavigateRequest(long id, NavigateRequestParams param)
            : base(id, param)
        {
            
        }
    }
}
