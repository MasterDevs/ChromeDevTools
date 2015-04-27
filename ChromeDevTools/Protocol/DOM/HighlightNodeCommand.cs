using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or objectId must be specified.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightNode)]
	public class HighlightNodeCommand
	{
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance.
		/// </summary>
		public HighlightConfig HighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the node to highlight.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the backend node to highlight.
		/// </summary>
		public long BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets JavaScript object id of the node to be highlighted.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
