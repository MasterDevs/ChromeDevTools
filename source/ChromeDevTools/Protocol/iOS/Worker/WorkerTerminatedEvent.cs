using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Event(ProtocolName.Worker.WorkerTerminated)]
	[SupportedBy("iOS")]
	public class WorkerTerminatedEvent
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public long WorkerId { get; set; }
	}
}
