using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Returns relevant application cache data for the document in given frame.
	/// </summary>
	[CommandResponse(ProtocolName.ApplicationCache.GetApplicationCacheForFrame)]
	public class GetApplicationCacheForFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets Relevant application cache data for the document in given frame.
		/// </summary>
		public ApplicationCache ApplicationCache { get; set; }
	}
}
