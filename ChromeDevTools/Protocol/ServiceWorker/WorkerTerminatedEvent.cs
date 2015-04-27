using ChromeDevTools;

namespace ChromeDevTools.Protocol.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.WorkerTerminated)]
	public class WorkerTerminatedEvent
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public string WorkerId { get; set; }
	}
}
