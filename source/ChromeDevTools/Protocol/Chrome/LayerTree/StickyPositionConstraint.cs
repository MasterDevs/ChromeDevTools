using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Sticky position constraints.
	/// </summary>
	[SupportedBy("Chrome")]
	public class StickyPositionConstraint
	{
		/// <summary>
		/// Gets or sets Layout rectangle of the sticky element before being shifted
		/// </summary>
		public DOM.Rect StickyBoxRect { get; set; }
		/// <summary>
		/// Gets or sets Layout rectangle of the containing block of the sticky element
		/// </summary>
		public DOM.Rect ContainingBlockRect { get; set; }
		/// <summary>
		/// Gets or sets The nearest sticky layer that shifts the sticky box
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string NearestLayerShiftingStickyBox { get; set; }
		/// <summary>
		/// Gets or sets The nearest sticky layer that shifts the containing block
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string NearestLayerShiftingContainingBlock { get; set; }
	}
}
