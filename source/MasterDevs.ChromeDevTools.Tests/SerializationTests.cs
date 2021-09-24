using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MasterDevs.ChromeDevTools.Protocol.Chrome.DOM;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Page;
using Newtonsoft.Json;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime;
using NUnit.Framework;

namespace MasterDevs.ChromeDevTools.Tests {
	[TestFixture]
	public class SerializationTests {
		[Test]
		public void ShadowRootTypeTest() {
			// Makes sure the "user-agent" property in the ShadowRootType class is serialized as "user-agent" and not
			// as "userAgent"
			var value = JsonConvert.DeserializeObject<ShadowRootType>("\"user-agent\"");
		}

		[Test]
		public void RunScriptCommandTest() {
			// The RunScriptCommand class has optional, non-nullable properties. This test makes sure they
			// actually are nullable, and are not serialized if no explicit value is given.
			var runScriptCommand = new RunScriptCommand();
			var value = JsonConvert.SerializeObject(runScriptCommand);

			// The only required parameter is ScriptId, so that's the only value which should be visible
			// when using default serialization.
			Assert.AreEqual("{\"ScriptId\":null}", value);
		}

		const int ViewPortWidth = 1440;
		const int ViewPortHeight = 900;

		[Test]
		public void ScreenshotGoogle() {
			Task.Run(async () => {
				// synchronization
				var screenshotDone = new ManualResetEventSlim();

				// STEP 1 - Run Chrome
				var chromeProcessFactory = new ChromeProcessFactory(new StubbornDirectoryCleaner());
				using (var chromeProcess = chromeProcessFactory.Create(9222, true)) {
					// STEP 2 - Create a debugging session
					var sessionInfo = (await chromeProcess.GetSessionInfo()).LastOrDefault();
					var chromeSessionFactory = new ChromeSessionFactory();
					var chromeSession = chromeSessionFactory.Create(sessionInfo.WebSocketDebuggerUrl);


					// STEP 3 - Register for events (in this case, "Page" domain events)
					// send an command to tell chrome to send us all Page events
					// but we only subscribe to certain events in this session
					var pageEnableResult = await chromeSession.SendAsync<Protocol.Chrome.Page.EnableCommand>();

					chromeSession.Subscribe<LoadEventFiredEvent>(loadEventFired => {
						// we cannot block in event handler, hence the task
						Task.Run(async () => {
							var documentNodeId = (await chromeSession.SendAsync(new GetDocumentCommand())).Result.Root.NodeId;
							var bodyNodeId =
								(await chromeSession.SendAsync(new QuerySelectorCommand {
									NodeId = documentNodeId,
									Selector = "body"
								})).Result.NodeId;
							var height = (await chromeSession.SendAsync(new GetBoxModelCommand { NodeId = bodyNodeId })).Result.Model.Height;

							await chromeSession.SendAsync(new SetDeviceMetricsOverrideCommand {
								Width = ViewPortWidth,
								Height = height,
								Scale = 1
							});

							var screenshot = await chromeSession.SendAsync(new CaptureScreenshotCommand { Format = "png" });

							var data = Convert.FromBase64String(screenshot.Result.Data);
							Assert.IsNotNull(data);
							Assert.IsNotEmpty(data);


							// tell the main thread we are done
							screenshotDone.Set();
						});
					});

					var navigateResponse = await chromeSession.SendAsync(new NavigateCommand {
						Url = "http://www.google.com"
					});
					Console.WriteLine("NavigateResponse: " + navigateResponse.Id);

					// STEP 4 - Send a command
					//
					// Here we are sending a commands to tell chrome to set the viewport size 
					// and navigate to the specified URL
					await chromeSession.SendAsync(new SetDeviceMetricsOverrideCommand {
						Width = ViewPortWidth,
						Height = ViewPortHeight,
						Scale = 1
					});

					// wait for screenshoting thread to (start and) finish
					screenshotDone.Wait();
				}
			}).Wait();
		}

		[Test]
		public void GooglePDF() {
			Task.Run(async () => {
				// synchronization
				var pdfDone = new ManualResetEventSlim();

				// STEP 1 - Run Chrome
				var chromeProcessFactory = new ChromeProcessFactory(new StubbornDirectoryCleaner());
				using (var chromeProcess = chromeProcessFactory.Create(9222, true)) {
					// STEP 2 - Create a debugging session
					var sessionInfo = (await chromeProcess.GetSessionInfo()).LastOrDefault();
					var chromeSessionFactory = new ChromeSessionFactory();
					var chromeSession = chromeSessionFactory.Create(sessionInfo.WebSocketDebuggerUrl);


					// STEP 3 - Register for events (in this case, "Page" domain events)
					// send an command to tell chrome to send us all Page events
					// but we only subscribe to certain events in this session
					var pageEnableResult = await chromeSession.SendAsync<Protocol.Chrome.Page.EnableCommand>();

					chromeSession.Subscribe<LoadEventFiredEvent>(loadEventFired => {
						// we cannot block in event handler, hence the task
						Task.Run(async () => {
							var response = await chromeSession.SendAsync(new PrintToPDFCommand { Landscape = true });
							if (response is ErrorResponse) {
								Assert.Fail("Error executing PDF command");
							}
							Assert.IsNotNull(response);
							var data = Convert.FromBase64String(response.Result.Data);
							Assert.IsNotNull(data);
							Assert.IsNotEmpty(data);

							// tell the main thread we are done
							pdfDone.Set();
						});
					});

					var navigateResponse = await chromeSession.SendAsync(new NavigateCommand {
						Url = "http://www.google.com"
					});
					Console.WriteLine("NavigateResponse: " + navigateResponse.Id);

					// STEP 4 - Send a command
					//
					// Here we are sending a commands to tell chrome to set the viewport size 
					// and navigate to the specified URL
					await chromeSession.SendAsync(new SetDeviceMetricsOverrideCommand {
						Width = ViewPortWidth,
						Height = ViewPortHeight,
						Scale = 1
					});

					// wait for screenshoting thread to (start and) finish
					pdfDone.Wait();
				}
			}).Wait();
		}
	}
}