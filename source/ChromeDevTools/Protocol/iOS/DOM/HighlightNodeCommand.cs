using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or objectId must be specified.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightNode)]
	[SupportedBy("iOS")]
	public class HighlightNodeCommand: ICommand<HighlightNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance.
		/// </summary>
		public HighlightConfig HighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the node to highlight.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Gets or sets JavaScript object id of the node to be highlighted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}
