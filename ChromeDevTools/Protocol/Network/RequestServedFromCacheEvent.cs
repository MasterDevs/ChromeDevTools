using ChromeDevTools;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired if request ended up loading from cache.
	/// </summary>
	[Event(ProtocolName.Network.RequestServedFromCache)]
	public class RequestServedFromCacheEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
	}
}
