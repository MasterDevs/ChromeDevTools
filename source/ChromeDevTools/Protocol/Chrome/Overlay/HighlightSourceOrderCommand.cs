using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Highlights the source order of the children of the DOM node with given id or with the given
	/// JavaScript object wrapper. Either nodeId or objectId must be specified.
	/// </summary>
	[Command(ProtocolName.Overlay.HighlightSourceOrder)]
	[SupportedBy("Chrome")]
	public class HighlightSourceOrderCommand: ICommand<HighlightSourceOrderCommandResponse>
	{
		/// <summary>
		/// Gets or sets A descriptor for the appearance of the overlay drawing.
		/// </summary>
		public SourceOrderConfig SourceOrderConfig { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the node to highlight.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the backend node to highlight.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets JavaScript object id of the node to be highlighted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}
