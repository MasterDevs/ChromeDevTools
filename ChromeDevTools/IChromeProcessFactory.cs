using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeDevTools
{
    public interface IChromeProcessFactory
    {
        IChromeProcess Create(int port);
    }
}
