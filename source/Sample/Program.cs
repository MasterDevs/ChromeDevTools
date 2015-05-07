using MasterDevs.ChromeDevTools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MasterDevs.ChromeDevTools.Protocol;
using WebSocket4Net;
using MasterDevs.ChromeDevTools.Protocol.Page;

namespace MasterDevs.ChromeDevTools.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // STEP 1 - Run Chrome
            var chromeProcessFactory = new ChromeProcessFactory();
            using (var chromeProcess = chromeProcessFactory.Create(9222))
            {
                // STEP 2 - Create a debugging session
                var endpointUrl = chromeProcess.GetSessions().Result.LastOrDefault();
                var chromeSessionFactory = new ChromeSessionFactory();
                var chromeSession = chromeSessionFactory.Create(endpointUrl);

                // STEP 3 - Send a command
                // 
                // Here we are sending a command to tell chrome to navigate to
                // the specified URL
                var navigateResponse = chromeSession.SendAsync(new NavigateCommand
                    {
                        Url = "http://www.google.com"
                    })
                    .Result;
                Console.WriteLine("NavigateResponse: " + navigateResponse.Id);

                // STEP 4 - Register for events (in this case, "Page" domain events)
                // send an event to tell chrome to send us all Page events
                // but we only subscribe to certain events in this session
                var pageEnableResult = chromeSession.SendAsync<ChromeDevTools.Protocol.Page.EnableCommand>().Result;
                Console.WriteLine("PageEnable: " + pageEnableResult.Id);
                chromeSession.Subscribe<Protocol.Page.DomContentEventFiredEvent>((o, e) =>
                    {
                        var domContentEvent = (Event<DomContentEventFiredEvent>)e;
                        Console.WriteLine("DomContentEvent: " + domContentEvent.Params.Timestamp);
                    });
                // you might never see this, but that's what an event is ... right?
                chromeSession.Subscribe<Protocol.Page.FrameStartedLoadingEvent>((o, e) =>
                    {
                        var frameStartedLoadingEvent = (Event<FrameStartedLoadingEvent>)e;
                        Console.WriteLine("FrameStartedLoading: " + frameStartedLoadingEvent.Params.FrameId);
                    });

                Console.ReadLine();
            }

        }

    }
}
