using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Requests information about platform fonts which we used to render child TextNodes in the given node.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetPlatformFontsForNode)]
	[SupportedBy("Chrome")]
	public class GetPlatformFontsForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Usage statistics for every employed platform font.
		/// </summary>
		public PlatformFontUsage[] Fonts { get; set; }
	}
}
