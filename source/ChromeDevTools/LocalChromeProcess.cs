using System;
using System.Diagnostics;

namespace MasterDevs.ChromeDevTools
{
    public class LocalChromeProcess : RemoteChromeProcess
    {
        public LocalChromeProcess(Uri remoteDebuggingUri, Action disposeUserDirectory, Process process)
            : base(remoteDebuggingUri)
        {
            DisposeUserDirectory = disposeUserDirectory;
            Process = process;
        }

        public Action DisposeUserDirectory { get; set; }
        public Process Process { get; set; }

        public override void Dispose()
        {
            base.Dispose();

            Process.Kill();
            Process.WaitForExit();
//            Process.Close();
            DisposeUserDirectory();
        }
    }
}