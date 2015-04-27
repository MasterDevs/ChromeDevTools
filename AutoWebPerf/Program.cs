using ChromeDevTools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChromeDevTools.Protocol;
using WebSocket4Net;
using ChromeDevTools.Protocol.Page;

namespace AutoWebPerf
{
    class Program
    {
        static void Main(string[] args)
        {

            var chromeProcessFactory = new ChromeProcessFactory();
            using (var chromeProcess = chromeProcessFactory.Create(9222))
            {
                var endpointUrl = chromeProcess.GetSessions().Result.LastOrDefault();
                var chromeSessionFactory = new ChromeSessionFactory();

                var chromeSession = chromeSessionFactory.Create(endpointUrl);
                var pageEnableResult = chromeSession.SendAsync<ChromeDevTools.Protocol.Network.EnableCommand>().Result;
                chromeSession.Subscribe<ChromeDevTools.Protocol.Network.ResponseReceivedEvent>((o, e) =>
                    {
                        Console.WriteLine("Response Received");
                    });
                chromeSession.SendAsync(new NavigateCommand
                    {
                        Url = "http://www.google.com"
                    });

                Console.ReadLine();
            }

        }
        
    }
}
