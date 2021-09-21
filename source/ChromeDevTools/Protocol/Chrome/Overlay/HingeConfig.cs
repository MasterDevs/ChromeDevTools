using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Configuration for dual screen hinge
	/// </summary>
	[SupportedBy("Chrome")]
	public class HingeConfig
	{
		/// <summary>
		/// Gets or sets A rectangle represent hinge
		/// </summary>
		public DOM.Rect Rect { get; set; }
		/// <summary>
		/// Gets or sets The content box highlight fill color (default: a dark color).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ContentColor { get; set; }
		/// <summary>
		/// Gets or sets The content box highlight outline color (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA OutlineColor { get; set; }
	}
}
