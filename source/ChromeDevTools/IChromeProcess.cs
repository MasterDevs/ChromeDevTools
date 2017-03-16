using System;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeProcess : IDisposable
    {
        Task<ChromeSessionInfo[]> GetSessionInfo();

        Task<ChromeSessionInfo> StartNewSession();

        Uri RemoteDebuggingUri { get; }
    }
}