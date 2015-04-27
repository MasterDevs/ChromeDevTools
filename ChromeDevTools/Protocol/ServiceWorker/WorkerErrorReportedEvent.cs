using ChromeDevTools;

namespace ChromeDevTools.Protocol.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.WorkerErrorReported)]
	public class WorkerErrorReportedEvent
	{
		/// <summary>
		/// Gets or sets ErrorMessage
		/// </summary>
		public ServiceWorkerErrorMessage ErrorMessage { get; set; }
	}
}
