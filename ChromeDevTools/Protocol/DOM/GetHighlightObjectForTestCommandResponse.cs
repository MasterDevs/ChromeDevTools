using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// For testing.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetHighlightObjectForTest)]
	public class GetHighlightObjectForTestCommandResponse
	{
		/// <summary>
		/// Gets or sets Highlight data for the node.
		/// </summary>
		public object Highlight { get; set; }
	}
}
