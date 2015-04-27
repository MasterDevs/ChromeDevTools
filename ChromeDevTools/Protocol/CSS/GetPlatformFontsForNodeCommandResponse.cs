using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Requests information about platform fonts which we used to render child TextNodes in the given node.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetPlatformFontsForNode)]
	public class GetPlatformFontsForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Font family name which is determined by computed style.
		/// </summary>
		public string CssFamilyName { get; set; }
		/// <summary>
		/// Gets or sets Usage statistics for every employed platform font.
		/// </summary>
		public PlatformFontUsage[] Fonts { get; set; }
	}
}
