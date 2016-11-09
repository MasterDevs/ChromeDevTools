using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	/// <summary>
	/// Information about a compositing layer.
	/// </summary>
	[SupportedBy("iOS")]
	public class Layer
	{
		/// <summary>
		/// Gets or sets The unique id for this layer.
		/// </summary>
		public string LayerId { get; set; }
		/// <summary>
		/// Gets or sets The id for the node associated with this layer.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Bounds of the layer in absolute page coordinates.
		/// </summary>
		public IntRect Bounds { get; set; }
		/// <summary>
		/// Gets or sets Indicates how many time this layer has painted.
		/// </summary>
		public long PaintCount { get; set; }
		/// <summary>
		/// Gets or sets Estimated memory used by this layer.
		/// </summary>
		public long Memory { get; set; }
		/// <summary>
		/// Gets or sets The bounds of the composited layer.
		/// </summary>
		public IntRect CompositedBounds { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether this layer is associated with an element hosted in a shadow tree.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsInShadowTree { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether this layer was used to provide a reflection for the element.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsReflection { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether the layer is attached to a pseudo element that is CSS generated content.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsGeneratedContent { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether the layer was created for a CSS anonymous block or box.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsAnonymous { get; set; }
		/// <summary>
		/// Gets or sets The id for the pseudo element associated with this layer.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PseudoElementId { get; set; }
		/// <summary>
		/// Gets or sets The name of the CSS pseudo-element that prompted the layer to be generated.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PseudoElement { get; set; }
	}
}
