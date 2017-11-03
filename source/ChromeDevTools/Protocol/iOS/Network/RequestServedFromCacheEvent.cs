using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Fired if request ended up loading from cache.
	/// </summary>
	[Event(ProtocolName.Network.RequestServedFromCache)]
	[SupportedBy("iOS")]
	public class RequestServedFromCacheEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
	}
}
