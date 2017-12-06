using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns all supported system font family names.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetSupportedSystemFontFamilyNames)]
	[SupportedBy("iOS")]
	public class GetSupportedSystemFontFamilyNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets Supported system font families.
		/// </summary>
		public string[] FontFamilyNames { get; set; }
	}
}
