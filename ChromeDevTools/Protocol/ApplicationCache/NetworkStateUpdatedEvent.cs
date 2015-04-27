using ChromeDevTools;

namespace ChromeDevTools.Protocol.ApplicationCache
{
	[Event(ProtocolName.ApplicationCache.NetworkStateUpdated)]
	public class NetworkStateUpdatedEvent
	{
		/// <summary>
		/// Gets or sets IsNowOnline
		/// </summary>
		public bool IsNowOnline { get; set; }
	}
}
