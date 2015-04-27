using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Returns relevant application cache data for the document in given frame.
	/// </summary>
	[Command(ProtocolName.ApplicationCache.GetApplicationCacheForFrame)]
	public class GetApplicationCacheForFrameCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing document whose application cache is retrieved.
		/// </summary>
		public string FrameId { get; set; }
	}
}
