using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Returns manifest URL for document in the given frame.
	/// </summary>
	[Command(ProtocolName.ApplicationCache.GetManifestForFrame)]
	public class GetManifestForFrameCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing document whose manifest is retrieved.
		/// </summary>
		public string FrameId { get; set; }
	}
}
