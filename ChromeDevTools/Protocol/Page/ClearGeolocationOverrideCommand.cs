using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Clears the overriden Geolocation Position and Error.
	/// </summary>
	[Command(ProtocolName.Page.ClearGeolocationOverride)]
	public class ClearGeolocationOverrideCommand
	{
	}
}
