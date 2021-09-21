using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns iframe node that owns iframe with the given domain.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetFrameOwner)]
	[SupportedBy("Chrome")]
	public class GetFrameOwnerCommandResponse
	{
		/// <summary>
		/// Gets or sets Resulting node.
		/// </summary>
		public long BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets Id of the node at given coordinates, only when enabled and requested document.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
	}
}
