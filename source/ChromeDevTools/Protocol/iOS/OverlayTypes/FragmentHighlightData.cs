using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	/// <summary>
	/// Data required to highlight multiple quads.
	/// </summary>
	[SupportedBy("iOS")]
	public class FragmentHighlightData
	{
		/// <summary>
		/// Gets or sets Quads for which the highlight should be applied.
		/// </summary>
		public Point[][] Quads { get; set; }
		/// <summary>
		/// Gets or sets ContentColor
		/// </summary>
		public string ContentColor { get; set; }
		/// <summary>
		/// Gets or sets ContentOutlineColor
		/// </summary>
		public string ContentOutlineColor { get; set; }
		/// <summary>
		/// Gets or sets PaddingColor
		/// </summary>
		public string PaddingColor { get; set; }
		/// <summary>
		/// Gets or sets BorderColor
		/// </summary>
		public string BorderColor { get; set; }
		/// <summary>
		/// Gets or sets MarginColor
		/// </summary>
		public string MarginColor { get; set; }
		/// <summary>
		/// Gets or sets RegionClippingArea
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Point[] RegionClippingArea { get; set; }
	}
}
