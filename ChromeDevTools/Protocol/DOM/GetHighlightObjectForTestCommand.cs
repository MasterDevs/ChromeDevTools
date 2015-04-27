using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// For testing.
	/// </summary>
	[Command(ProtocolName.DOM.GetHighlightObjectForTest)]
	public class GetHighlightObjectForTestCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to get highlight object for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
