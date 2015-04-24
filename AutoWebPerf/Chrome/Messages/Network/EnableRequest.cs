using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages.Network
{
    [MethodName(MethodName.Network.Enable)]
    public class EnableRequest : Messages.Request
    {
        public EnableRequest(long id)
            : base(id)
        {                
        }
    }
}
