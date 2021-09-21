using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Style information for drawing a box.
	/// </summary>
	[SupportedBy("Chrome")]
	public class BoxStyle
	{
		/// <summary>
		/// Gets or sets The background color for the box (default: transparent)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA FillColor { get; set; }
		/// <summary>
		/// Gets or sets The hatching color for the box (default: transparent)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA HatchColor { get; set; }
	}
}
