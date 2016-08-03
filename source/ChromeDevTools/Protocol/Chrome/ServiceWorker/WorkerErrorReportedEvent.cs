using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.WorkerErrorReported)]
	[SupportedBy("Chrome")]
	public class WorkerErrorReportedEvent
	{
		/// <summary>
		/// Gets or sets ErrorMessage
		/// </summary>
		public ServiceWorkerErrorMessage ErrorMessage { get; set; }
	}
}
