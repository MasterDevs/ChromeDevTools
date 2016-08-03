using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns all supported system font family names.
	/// </summary>
	[Command(ProtocolName.CSS.GetSupportedSystemFontFamilyNames)]
	[SupportedBy("iOS")]
	public class GetSupportedSystemFontFamilyNamesCommand
	{
	}
}
