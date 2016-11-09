using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Worker
{
	[Event(ProtocolName.Worker.WorkerTerminated)]
	[SupportedBy("Chrome")]
	public class WorkerTerminatedEvent
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public string WorkerId { get; set; }
	}
}
