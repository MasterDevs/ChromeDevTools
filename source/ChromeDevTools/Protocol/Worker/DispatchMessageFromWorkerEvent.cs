using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	[Event(ProtocolName.Worker.DispatchMessageFromWorker)]
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
