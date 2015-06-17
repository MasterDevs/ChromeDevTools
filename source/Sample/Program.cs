using MasterDevs.ChromeDevTools.Protocol.Page;
using System;
using System.Linq;

namespace MasterDevs.ChromeDevTools.Sample
{
    internal class Program
    {
        private static void Main(string[] args)
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
                chromeSession.Subscribe<Protocol.Page.DomContentEventFiredEvent>(domContentEvent =>
                    {
                        Console.WriteLine("DomContentEvent: " + domContentEvent.Timestamp);
                    });
                // you might never see this, but that's what an event is ... right?
                chromeSession.Subscribe<Protocol.Page.FrameStartedLoadingEvent>(frameStartedLoadingEvent =>
                    {
                        Console.WriteLine("FrameStartedLoading: " + frameStartedLoadingEvent.FrameId);
                    });

                Console.ReadLine();
            }
        }
    }
}