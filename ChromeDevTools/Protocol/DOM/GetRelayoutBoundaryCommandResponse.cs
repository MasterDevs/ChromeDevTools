using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns the id of the nearest ancestor that is a relayout boundary.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetRelayoutBoundary)]
	public class GetRelayoutBoundaryCommandResponse
	{
		/// <summary>
		/// Gets or sets Relayout boundary node id for the given node.
		/// </summary>
		public long NodeId { get; set; }
	}
}
