using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeDevTools
{
    public interface IChromeProcess : IDisposable
    {
        Task<string[]> GetSessions();

        DirectoryInfo UserDirectory { get; }

        Process Process { get; }

        string RemoteDebuggingUri { get; }
    }
}
