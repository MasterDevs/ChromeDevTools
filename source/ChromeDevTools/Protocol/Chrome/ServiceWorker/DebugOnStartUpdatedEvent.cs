using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.DebugOnStartUpdated)]
	[SupportedBy("Chrome")]
	public class DebugOnStartUpdatedEvent
	{
		/// <summary>
		/// Gets or sets DebugOnStart
		/// </summary>
		public bool DebugOnStart { get; set; }
	}
}
