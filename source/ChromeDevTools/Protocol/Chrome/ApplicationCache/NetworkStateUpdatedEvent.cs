using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ApplicationCache
{
	[Event(ProtocolName.ApplicationCache.NetworkStateUpdated)]
	[SupportedBy("Chrome")]
	public class NetworkStateUpdatedEvent
	{
		/// <summary>
		/// Gets or sets IsNowOnline
		/// </summary>
		public bool IsNowOnline { get; set; }
	}
}
