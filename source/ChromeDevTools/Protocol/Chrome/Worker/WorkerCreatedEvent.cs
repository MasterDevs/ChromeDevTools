using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Worker
{
	[Event(ProtocolName.Worker.WorkerCreated)]
	[SupportedBy("Chrome")]
	public class WorkerCreatedEvent
	{
		/// <summary>
		/// Gets or sets WorkerId
		/// </summary>
		public string WorkerId { get; set; }
		/// <summary>
		/// Gets or sets Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets InspectorConnected
		/// </summary>
		public bool InspectorConnected { get; set; }
	}
}
