using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class ScrollSnapContainerHighlightConfig
	{
		/// <summary>
		/// Gets or sets The style of the snapport border (default: transparent)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle SnapportBorder { get; set; }
		/// <summary>
		/// Gets or sets The style of the snap area border (default: transparent)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle SnapAreaBorder { get; set; }
		/// <summary>
		/// Gets or sets The margin highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ScrollMarginColor { get; set; }
		/// <summary>
		/// Gets or sets The padding highlight fill color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ScrollPaddingColor { get; set; }
	}
}
