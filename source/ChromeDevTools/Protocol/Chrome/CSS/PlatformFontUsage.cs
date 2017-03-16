using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Information about amount of glyphs that were rendered with given font.
	/// </summary>
	[SupportedBy("Chrome")]
	public class PlatformFontUsage
	{
		/// <summary>
		/// Gets or sets Font's family name reported by platform.
		/// </summary>
		public string FamilyName { get; set; }
		/// <summary>
		/// Gets or sets Indicates if the font was downloaded or resolved locally.
		/// </summary>
		public bool IsCustomFont { get; set; }
		/// <summary>
		/// Gets or sets Amount of glyphs that were rendered with this font.
		/// </summary>
		public double GlyphCount { get; set; }
	}
}
