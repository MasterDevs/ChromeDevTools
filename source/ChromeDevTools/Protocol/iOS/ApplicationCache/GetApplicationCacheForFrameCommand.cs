using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.ApplicationCache
{
	/// <summary>
	/// Returns relevant application cache data for the document in given frame.
	/// </summary>
	[Command(ProtocolName.ApplicationCache.GetApplicationCacheForFrame)]
	[SupportedBy("iOS")]
	public class GetApplicationCacheForFrameCommand: ICommand<GetApplicationCacheForFrameCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing document whose application cache is retrieved.
		/// </summary>
		public string FrameId { get; set; }
	}
}
