using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Style information for drawing a line.
	/// </summary>
	[SupportedBy("Chrome")]
	public class LineStyle
	{
		/// <summary>
		/// Gets or sets The color of the line (default: transparent)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA Color { get; set; }
		/// <summary>
		/// Gets or sets The line pattern (default: solid)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Pattern { get; set; }
	}
}
