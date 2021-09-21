using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// For Source Order Viewer testing.
	/// </summary>
	[Command(ProtocolName.Overlay.GetSourceOrderHighlightObjectForTest)]
	[SupportedBy("Chrome")]
	public class GetSourceOrderHighlightObjectForTestCommand: ICommand<GetSourceOrderHighlightObjectForTestCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}
