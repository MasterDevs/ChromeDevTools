using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns node id at given location. Depending on whether DOM domain is enabled, nodeId is
	/// either returned or not.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetNodeForLocation)]
	[SupportedBy("Chrome")]
	public class GetNodeForLocationCommandResponse
	{
		/// <summary>
		/// Gets or sets Resulting node.
		/// </summary>
		public long BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets Frame this node belongs to.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Id of the node at given coordinates, only when enabled and requested document.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
	}
}
