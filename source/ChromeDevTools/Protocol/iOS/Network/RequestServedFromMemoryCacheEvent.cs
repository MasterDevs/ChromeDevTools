using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Fired when HTTP request has been served from memory cache.
	/// </summary>
	[Event(ProtocolName.Network.RequestServedFromMemoryCache)]
	[SupportedBy("iOS")]
	public class RequestServedFromMemoryCacheEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Frame identifier.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Loader identifier.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets URL of the document this request is loaded for.
		/// </summary>
		public string DocumentURL { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Request initiator.
		/// </summary>
		public Initiator Initiator { get; set; }
		/// <summary>
		/// Gets or sets Cached resource data.
		/// </summary>
		public CachedResource Resource { get; set; }
	}
}
