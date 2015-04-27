using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns node id at given location.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetNodeForLocation)]
	public class GetNodeForLocationCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the node at given coordinates.
		/// </summary>
		public long NodeId { get; set; }
	}
}
