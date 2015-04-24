using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages
{
    interface IResponseFactory
    {
        IResponse Create(string responseText);

        IResponse Create(byte[] responseBytes);
    }
}
