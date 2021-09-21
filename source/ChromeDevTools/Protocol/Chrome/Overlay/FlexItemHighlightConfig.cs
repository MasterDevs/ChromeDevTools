using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Configuration data for the highlighting of Flex item elements.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FlexItemHighlightConfig
	{
		/// <summary>
		/// Gets or sets Style of the box representing the item's base size
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BoxStyle BaseSizeBox { get; set; }
		/// <summary>
		/// Gets or sets Style of the border around the box representing the item's base size
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle BaseSizeBorder { get; set; }
		/// <summary>
		/// Gets or sets Style of the arrow representing if the item grew or shrank
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle FlexibilityArrow { get; set; }
	}
}
