using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeDevTools
{
    public interface IChromeSession
    {
        Task<ICommandResponse> SendAsync<T>(T parameter);

        Task<ICommandResponse> SendAsync<T>();

        void Subscribe<T>(EventHandler handler);
    }
}
