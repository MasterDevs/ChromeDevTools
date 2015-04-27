using ChromeDevTools;

namespace ChromeDevTools.Protocol.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.WorkerVersionUpdated)]
	public class WorkerVersionUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Versions
		/// </summary>
		public ServiceWorkerVersion[] Versions { get; set; }
	}
}
