using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns the id of the nearest ancestor that is a relayout boundary.
	/// </summary>
	[Command(ProtocolName.DOM.GetRelayoutBoundary)]
	public class GetRelayoutBoundaryCommand
	{
		/// <summary>
		/// Gets or sets Id of the node.
		/// </summary>
		public long NodeId { get; set; }
	}
}
