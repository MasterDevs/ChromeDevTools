using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeSessionFactory
    {
        IChromeSession Create(string endpointUrl);
    }
}
