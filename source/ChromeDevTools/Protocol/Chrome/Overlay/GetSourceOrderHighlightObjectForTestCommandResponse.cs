using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// For Source Order Viewer testing.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.GetSourceOrderHighlightObjectForTest)]
	[SupportedBy("Chrome")]
	public class GetSourceOrderHighlightObjectForTestCommandResponse
	{
		/// <summary>
		/// Gets or sets Source order highlight data for the node id provided.
		/// </summary>
		public object Highlight { get; set; }
	}
}
