using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// A node in the accessibility tree.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AXNode
	{
		/// <summary>
		/// Gets or sets Unique identifier for this node.
		/// </summary>
		public string NodeId { get; set; }
		/// <summary>
		/// Gets or sets Whether this node is ignored for accessibility
		/// </summary>
		public bool Ignored { get; set; }
		/// <summary>
		/// Gets or sets Collection of reasons why this node is hidden.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXProperty[] IgnoredReasons { get; set; }
		/// <summary>
		/// Gets or sets This <code>Node</code>'s role, whether explicit or implicit.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Role { get; set; }
		/// <summary>
		/// Gets or sets The accessible name for this <code>Node</code>.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Name { get; set; }
		/// <summary>
		/// Gets or sets The accessible description for this <code>Node</code>.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Description { get; set; }
		/// <summary>
		/// Gets or sets The value for this <code>Node</code>.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Value { get; set; }
		/// <summary>
		/// Gets or sets All other properties
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXProperty[] Properties { get; set; }
		/// <summary>
		/// Gets or sets IDs for each of this node's child nodes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] ChildIds { get; set; }
		/// <summary>
		/// Gets or sets The backend ID for the associated DOM node, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendDOMNodeId { get; set; }
	}
}
