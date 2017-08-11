using System;
using System.Diagnostics;
using System.IO;

namespace MasterDevs.ChromeDevTools
{
    public class ChromeProcessFactory : IChromeProcessFactory
    {
        public IDirectoryCleaner DirectoryCleaner { get; set; }

        public ChromeProcessFactory(IDirectoryCleaner directoryCleaner)
        {
            DirectoryCleaner = directoryCleaner;
        }

        public IChromeProcess Create(int port)
        {
            string path = Path.GetRandomFileName();
            var directoryInfo = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), path));
            var remoteDebuggingArg = $"--remote-debugging-port={port}";
            var userDirectoryArg = $"--user-data-dir=\"{directoryInfo.FullName}\"";
            const string headlessArg = "--headless --disable-gpu";
            var chromeProcessArgs = $"{headlessArg} {remoteDebuggingArg} {userDirectoryArg} --bwsi --no-first-run";
            var processStartInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", chromeProcessArgs);
            var chromeProcess = Process.Start(processStartInfo);

            string remoteDebuggingUrl = "http://localhost:" + port;
            return new LocalChromeProcess(new Uri(remoteDebuggingUrl), () => DirectoryCleaner.Delete(directoryInfo), chromeProcess);
        }
    }
}