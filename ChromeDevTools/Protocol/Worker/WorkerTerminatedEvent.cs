using ChromeDevTools;

namespace ChromeDevTools.Protocol.Worker
{
	[Event(ProtocolName.Worker.WorkerTerminated)]
	public class WorkerTerminatedEvent
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public string WorkerId { get; set; }
	}
}
