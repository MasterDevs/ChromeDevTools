using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

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
