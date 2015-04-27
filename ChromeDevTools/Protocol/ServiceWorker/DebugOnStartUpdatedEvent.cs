using ChromeDevTools;

namespace ChromeDevTools.Protocol.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.DebugOnStartUpdated)]
	public class DebugOnStartUpdatedEvent
	{
		/// <summary>
		/// Gets or sets DebugOnStart
		/// </summary>
		public bool DebugOnStart { get; set; }
	}
}
