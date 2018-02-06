using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetResourceTree)]
	[SupportedBy("Chrome")]
	public class GetResourceTreeCommandResponse
	{
		/// <summary>
		/// Gets or sets Present frame / resource tree structure.
		/// </summary>
		public FrameResourceTree FrameTree { get; set; }
	}
}
