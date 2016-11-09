using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Worker
{
	[Event(ProtocolName.Worker.DispatchMessageFromWorker)]
	[SupportedBy("Chrome")]
	public class DispatchMessageFromWorkerEvent
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public string WorkerId { get; set; }
		/// <summary>
		/// Gets or sets Message
		/// </summary>
		public string Message { get; set; }
	}
}
