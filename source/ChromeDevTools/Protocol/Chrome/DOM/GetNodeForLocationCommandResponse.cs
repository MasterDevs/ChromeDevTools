using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns node id at given location.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetNodeForLocation)]
	[SupportedBy("Chrome")]
	public class GetNodeForLocationCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the node at given coordinates.
		/// </summary>
		public long NodeId { get; set; }
	}
}
