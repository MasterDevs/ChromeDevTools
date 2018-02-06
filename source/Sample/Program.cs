using MasterDevs.ChromeDevTools.Protocol.Chrome.Page;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using MasterDevs.ChromeDevTools.Protocol.Chrome.DOM;
using Task = System.Threading.Tasks.Task;

namespace MasterDevs.ChromeDevTools.Sample
{
    internal class Program
    {
        const int ViewPortWidth = 1440;
        const int ViewPortHeight = 900;
        private static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                // STEP 1 - Run Chrome
                var chromeProcessFactory = new ChromeProcessFactory(new StubbornDirectoryCleaner());
                using (var chromeProcess = chromeProcessFactory.Create(9222, true))
                {
                    // STEP 2 - Handle communication errors
                    //
                    // There are two ways how to handle communication errors:
                    // 1) check .IsError() for every command before accessing the .Result
                    // 2) access the .Result directly and handle (or don't handle ..) the exception
                    // We are using here the second option
                    try
                    {
                        // STEP 3 - Create a debugging session
                        var sessionInfo = (await chromeProcess.GetSessionInfo()).LastOrDefault();
                        var chromeSessionFactory = new ChromeSessionFactory();
                        var chromeSession = chromeSessionFactory.Create(sessionInfo.WebSocketDebuggerUrl,OnError );

                        // STEP 4 - Send a command
                        //
                        // Here we are sending a commands to tell chrome to set the viewport size 
                        // and navigate to the specified URL
                        await chromeSession.SendAsync(new SetDeviceMetricsOverrideCommand
                        {
                            Width = ViewPortWidth,
                            Height = ViewPortHeight,
                            Scale = 1
                        });

                        var navigateResponse = await chromeSession.SendAsync(new NavigateCommand
                        {
                            Url = "http://www.google.com"
                        });
                        Console.WriteLine($"NavigateResponse: {navigateResponse.Id}");

                        // STEP 5 - Register for events (in this case, "Page" domain events)
                        //
                        // send an command to tell chrome to send us all Page events
                        // but we only subscribe to certain events in this session
                        var pageEnableResult = await chromeSession.SendAsync<Protocol.Chrome.Page.EnableCommand>();
                        Console.WriteLine($"PageEnable: {pageEnableResult.Id}");

                        // We cannot do other requests in event handler, therefore we only wait for the event to be triggered
                        // and continue in the main program flow
                        var loadEventFired = new ManualResetEventSlim();
                        chromeSession.Subscribe<LoadEventFiredEvent>(ev =>
                        {
                            Console.WriteLine($"LoadEventFiredEvent: {ev.Timestamp}");
                            loadEventFired.Set();
                        });
                        loadEventFired.Wait();

                        // The page is ready in the browser, now we can take the screenshot

                        // update the VisibleSize to include whole page (extending height)
                        var documentNodeId = (await chromeSession.SendAsync(new GetDocumentCommand()))
                            .Result.Root.NodeId;
                        var bodyNodeId =
                        (await chromeSession.SendAsync(new QuerySelectorCommand
                        {
                            NodeId = documentNodeId,
                            Selector = "body"
                        })).Result.NodeId;
                        var height = (await chromeSession.SendAsync(new GetBoxModelCommand {NodeId = bodyNodeId}))
                            .Result.Model.Height;

                        await chromeSession.SendAsync(new SetDeviceMetricsOverrideCommand
                        {
                            Width = ViewPortWidth,
                            Height = height,
                            Scale = 1
                        });

                        Console.WriteLine("Taking screenshot");
                        var screenshot = await chromeSession.SendAsync(new CaptureScreenshotCommand {Format = "png"});

                        var data = Convert.FromBase64String(screenshot.Result.Data);
                        File.WriteAllBytes("output.png", data);
                        Console.WriteLine("Screenshot stored");
                    }
                    catch (ResultNotAvailableException ex)
                    {
                        Console.WriteLine($"Error while taking screenshot: {ex.Message}");
                    }

                    Console.WriteLine("Exiting ..");
                }
            }).Wait();
        }

        private static void OnError(Exception exception)
        {
            Console.WriteLine("Error during communication:");
            Console.WriteLine(exception);
        }
    }
}