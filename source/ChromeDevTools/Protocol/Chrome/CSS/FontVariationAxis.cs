using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Information about font variation axes for variable fonts
	/// </summary>
	[SupportedBy("Chrome")]
	public class FontVariationAxis
	{
		/// <summary>
		/// Gets or sets The font-variation-setting tag (a.k.a. "axis tag").
		/// </summary>
		public string Tag { get; set; }
		/// <summary>
		/// Gets or sets Human-readable variation name in the default language (normally, "en").
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets The minimum value (inclusive) the font supports for this tag.
		/// </summary>
		public double MinValue { get; set; }
		/// <summary>
		/// Gets or sets The maximum value (inclusive) the font supports for this tag.
		/// </summary>
		public double MaxValue { get; set; }
		/// <summary>
		/// Gets or sets The default value.
		/// </summary>
		public double DefaultValue { get; set; }
	}
}
