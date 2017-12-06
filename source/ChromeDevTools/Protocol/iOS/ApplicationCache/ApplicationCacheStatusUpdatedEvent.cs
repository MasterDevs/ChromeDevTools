using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.ApplicationCache
{
	[Event(ProtocolName.ApplicationCache.ApplicationCacheStatusUpdated)]
	[SupportedBy("iOS")]
	public class ApplicationCacheStatusUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing document whose application cache updated status.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Manifest URL.
		/// </summary>
		public string ManifestURL { get; set; }
		/// <summary>
		/// Gets or sets Updated application cache status.
		/// </summary>
		public long Status { get; set; }
	}
}
