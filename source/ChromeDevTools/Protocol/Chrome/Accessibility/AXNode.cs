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
		/// Gets or sets This <code>Node</code>'s role, whether explicit or implicit.
		/// </summary>
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
		/// Gets or sets Help.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Help { get; set; }
		/// <summary>
		/// Gets or sets All other properties
		/// </summary>
		public AXProperty[] Properties { get; set; }
	}
}
