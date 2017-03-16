using System;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeProcess : IDisposable
    {
        Task<ChromeSessionInfo[]> GetSessions();

        Uri RemoteDebuggingUri { get; }
    }
}