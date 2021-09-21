using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// For Persistent Grid testing.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.GetGridHighlightObjectsForTest)]
	[SupportedBy("Chrome")]
	public class GetGridHighlightObjectsForTestCommandResponse
	{
		/// <summary>
		/// Gets or sets Grid Highlight data for the node ids provided.
		/// </summary>
		public object Highlights { get; set; }
	}
}
