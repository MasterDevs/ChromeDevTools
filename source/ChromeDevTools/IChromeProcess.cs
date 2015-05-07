using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeProcess : IDisposable
    {
        Task<string[]> GetSessions();

        DirectoryInfo UserDirectory { get; }

        Process Process { get; }

        string RemoteDebuggingUri { get; }
    }
}