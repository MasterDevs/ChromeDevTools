using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeDevTools
{
    public interface IMethodTypeMap
    {
        Type GetCommand(string method);

        Type GetCommandResponse(string method);

        Type GetEvent(string method);
    }
}
