using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ApplicationCache
{
	/// <summary>
	/// Returns manifest URL for document in the given frame.
	/// </summary>
	[Command(ProtocolName.ApplicationCache.GetManifestForFrame)]
	[SupportedBy("Chrome")]
	public class GetManifestForFrameCommand: ICommand<GetManifestForFrameCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing document whose manifest is retrieved.
		/// </summary>
		public string FrameId { get; set; }
	}
}
