using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Configuration data for the highlighting of page elements.
	/// </summary>
	[SupportedBy("Chrome")]
	public class HighlightConfig
	{
		/// <summary>
		/// Gets or sets Whether the node info tooltip should be shown (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowInfo { get; set; }
		/// <summary>
		/// Gets or sets Whether the node styles in the tooltip (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowStyles { get; set; }
		/// <summary>
		/// Gets or sets Whether the rulers should be shown (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowRulers { get; set; }
		/// <summary>
		/// Gets or sets Whether the a11y info should be shown (default: true).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowAccessibilityInfo { get; set; }
		/// <summary>
		/// Gets or sets Whether the extension lines from node to the rulers should be shown (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowExtensionLines { get; set; }
		/// <summary>
		/// Gets or sets The content box highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ContentColor { get; set; }
		/// <summary>
		/// Gets or sets The padding highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA PaddingColor { get; set; }
		/// <summary>
		/// Gets or sets The border highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA BorderColor { get; set; }
		/// <summary>
		/// Gets or sets The margin highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA MarginColor { get; set; }
		/// <summary>
		/// Gets or sets The event target element highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA EventTargetColor { get; set; }
		/// <summary>
		/// Gets or sets The shape outside fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ShapeColor { get; set; }
		/// <summary>
		/// Gets or sets The shape margin fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ShapeMarginColor { get; set; }
		/// <summary>
		/// Gets or sets The grid layout color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA CssGridColor { get; set; }
		/// <summary>
		/// Gets or sets The color format used to format color styles (default: hex).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ColorFormat ColorFormat { get; set; }
		/// <summary>
		/// Gets or sets The grid layout highlight configuration (default: all transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public GridHighlightConfig GridHighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets The flex container highlight configuration (default: all transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FlexContainerHighlightConfig FlexContainerHighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets The flex item highlight configuration (default: all transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FlexItemHighlightConfig FlexItemHighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets The contrast algorithm to use for the contrast ratio (default: aa).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ContrastAlgorithm ContrastAlgorithm { get; set; }
		/// <summary>
		/// Gets or sets The container query container highlight configuration (default: all transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ContainerQueryContainerHighlightConfig ContainerQueryContainerHighlightConfig { get; set; }
	}
}
