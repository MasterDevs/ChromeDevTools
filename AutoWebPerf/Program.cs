using AutoWebPerf.Chrome;
using AutoWebPerf.Chrome.Messages;
using AutoWebPerf.Chrome.Messages.Network;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace AutoWebPerf
{
    class Program
    {
        static void Main(string[] args)
        {
            IChromeProxy _chromeProxy = null;
            ChromeProcessInfo chromeProcessInfo = null;

            try
            {
                chromeProcessInfo = StartChrome();

                var c = new ChromeWrapper("http://localhost:" + ChromeRemoteDebuggingPort);
                var sessions = c.GetAvailableSessions();
                foreach (var s in sessions)
                    Console.WriteLine(s.url);

                if (sessions.Count == 0)
                    throw new Exception("All debugging sessions are taken.");
                


                // Will drive first tab session
                var sessionWSEndpoint = sessions.Last().webSocketDebuggerUrl;   // new tab window
                c.SetActiveSession(sessionWSEndpoint);
                c.NavigateTo("http://www.google.com");
                
                
                var requestFactory = new RequestFactory();
                _chromeProxy = new ChromeProxy(sessionWSEndpoint, new ResponseFactory(requestFactory));
                _chromeProxy.Init().Wait();
                var result = _chromeProxy.PublishAsync(requestFactory.CreateNetworkEnableRequest()).Result;
                _chromeProxy.Subscribe<RequestWillBeSentResponse>((o, e) =>
                        {
                            Console.WriteLine("We got it!");
                        });
                _chromeProxy.PublishAsync(requestFactory.CreateNavigateRequest("http://www.google.com")).Wait();
                

                Console.ReadLine();
            }
            finally
            {
                if(null != _chromeProxy)
                {
                    _chromeProxy.Dispose();
                }
                KillChrome(chromeProcessInfo);
            }

        }

        private static void KillChrome(ChromeProcessInfo chromeProcessInfo)
        {
            try
            {
                chromeProcessInfo.ChromeProcess.Kill();
            } catch
            {
                // right now, the process has been killed ... so i'm swallowing this during setup/testing
            }
            try
            {
                chromeProcessInfo.ChromeUserDirectory.Delete(true);
            } catch
            {
                Thread.Sleep(500);
                chromeProcessInfo.ChromeUserDirectory.Delete(true);
            }
        }

        private static ChromeProcessInfo StartChrome()
        {
            string path = Path.GetRandomFileName();
            var directoryInfo = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), path));
            var remoteDebuggingArg = "--remote-debugging-port=" + ChromeRemoteDebuggingPort;
            var userDirectoryArg = "--user-data-dir=\"" + directoryInfo.FullName + "\"";
            var chromeProcessArgs = remoteDebuggingArg + " " + userDirectoryArg + " --bwsi --no-first-run";
            var processStartInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", chromeProcessArgs);
            var chromeProcess = Process.Start(processStartInfo);
            return new ChromeProcessInfo
            {
                ChromeProcess = chromeProcess,
                ChromeUserDirectory = directoryInfo
            };
        }

        public const int ChromeRemoteDebuggingPort = 9222;
    }
}
