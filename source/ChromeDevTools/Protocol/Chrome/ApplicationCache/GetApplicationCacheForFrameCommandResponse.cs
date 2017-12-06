using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ApplicationCache
{
	/// <summary>
	/// Returns relevant application cache data for the document in given frame.
	/// </summary>
	[CommandResponse(ProtocolName.ApplicationCache.GetApplicationCacheForFrame)]
	[SupportedBy("Chrome")]
	public class GetApplicationCacheForFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets Relevant application cache data for the document in given frame.
		/// </summary>
		public ApplicationCache ApplicationCache { get; set; }
	}
}
