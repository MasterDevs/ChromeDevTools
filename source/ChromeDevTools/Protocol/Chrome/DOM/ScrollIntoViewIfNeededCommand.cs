using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Scrolls the specified rect of the given node into view if not already visible.
	/// Note: exactly one between nodeId, backendNodeId and objectId should be passed
	/// to identify the node.
	/// </summary>
	[Command(ProtocolName.DOM.ScrollIntoViewIfNeeded)]
	[SupportedBy("Chrome")]
	public class ScrollIntoViewIfNeededCommand: ICommand<ScrollIntoViewIfNeededCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the backend node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets JavaScript object id of the node wrapper.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets The rect to be scrolled into view, relative to the node's border box, in CSS pixels.
		/// When omitted, center of the node will be used, similar to Element.scrollIntoView.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Rect Rect { get; set; }
	}
}
