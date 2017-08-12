using MasterDevs.ChromeDevTools.Protocol.Chrome.Page;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using MasterDevs.ChromeDevTools.Protocol.Chrome.DOM;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation;
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
                // synchronization
                var screenshotDone = new ManualResetEventSlim();

                // STEP 1 - Run Chrome
                var chromeProcessFactory = new ChromeProcessFactory(new StubbornDirectoryCleaner());
                using (var chromeProcess = chromeProcessFactory.Create(9222))
                {
                    // STEP 2 - Create a debugging session
                    var sessionInfo = (await chromeProcess.GetSessionInfo()).LastOrDefault();
                    var chromeSessionFactory = new ChromeSessionFactory();
                    var chromeSession = chromeSessionFactory.Create(sessionInfo.WebSocketDebuggerUrl);

                    // STEP 3 - Send a command
                    //
                    // Here we are sending a commands to tell chrome to set the viewport size 
                    // and navigate to the specified URL
                    await chromeSession.SendAsync(new SetVisibleSizeCommand
                    {
                        Width = ViewPortWidth,
                        Height = ViewPortHeight
                    });

                    var navigateResponse = await chromeSession.SendAsync(new NavigateCommand
                    {
                        Url = "http://www.google.com"
                    });
                    Console.WriteLine("NavigateResponse: " + navigateResponse.Id);

                    // STEP 4 - Register for events (in this case, "Page" domain events)
                    // send an command to tell chrome to send us all Page events
                    // but we only subscribe to certain events in this session
                    var pageEnableResult = await chromeSession.SendAsync<Protocol.Chrome.Page.EnableCommand>();
                    Console.WriteLine("PageEnable: " + pageEnableResult.Id);

                    chromeSession.Subscribe<LoadEventFiredEvent>(loadEventFired =>
                    {
                        // we cannot block in event handler, hence the task
                        Task.Run(async () =>
                        {
                            Console.WriteLine("LoadEventFiredEvent: " + loadEventFired.Timestamp);

                            var documentNodeId =
                                ((CommandResponse<GetDocumentCommandResponse>)
                                    await chromeSession.SendAsync(new GetDocumentCommand())).Result.Root.NodeId;
                            var bodyNodeId =
                                ((CommandResponse<QuerySelectorCommandResponse>)
                                    await chromeSession.SendAsync(new QuerySelectorCommand
                                    {
                                        NodeId = documentNodeId,
                                        Selector = "body"
                                    })).Result.NodeId;
                            var height =
                                ((CommandResponse<GetBoxModelCommandResponse>)
                                    await chromeSession.SendAsync(new GetBoxModelCommand {NodeId = bodyNodeId})).Result
                                    .Model.Height;

                            await chromeSession.SendAsync(new SetVisibleSizeCommand {Width = ViewPortWidth, Height = height});

                            Console.WriteLine("Taking screenshot");
                            var screenshot =
                                (CommandResponse<CaptureScreenshotCommandResponse>)
                                    await chromeSession.SendAsync(new CaptureScreenshotCommand {Format = "png"});

                            var data = Convert.FromBase64String(screenshot.Result.Data);
                            File.WriteAllBytes("output.png", data);
                            Console.WriteLine("Screenshot stored");

                            // tell the main thread we are done
                            screenshotDone.Set();
                        });
                    });

                    // wait for screenshoting thread to (start and) finish
                    screenshotDone.Wait();

                    Console.WriteLine("Exiting ..");
                }
            }).Wait();
        }
    }
}