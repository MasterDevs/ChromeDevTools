using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace MasterDevs.ChromeDevTools
{
    public class LocalChromeProcess : RemoteChromeProcess
    {
        public LocalChromeProcess(Uri remoteDebuggingUri, DirectoryInfo userDirectory, Process process)
            : base(remoteDebuggingUri)
        {
            UserDirectory = userDirectory;
            Process = process;
        }

        public DirectoryInfo UserDirectory { get; set; }

        public Process Process { get; set; }

        public override void Dispose()
        {
            base.Dispose();

            Process.Kill();
            try
            {
                UserDirectory.Delete(true);
            }
            catch
            {
                Thread.Sleep(500);          // i'm being lazy because i'm tired
                UserDirectory.Delete(true);
            }
        }
    }
}