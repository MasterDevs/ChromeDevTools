using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.ApplicationCache
{
	[Event(ProtocolName.ApplicationCache.NetworkStateUpdated)]
	[SupportedBy("iOS")]
	public class NetworkStateUpdatedEvent
	{
		/// <summary>
		/// Gets or sets IsNowOnline
		/// </summary>
		public bool IsNowOnline { get; set; }
	}
}
