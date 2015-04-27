using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Clears the overriden Geolocation Position and Error.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ClearGeolocationOverride)]
	public class ClearGeolocationOverrideCommandResponse
	{
	}
}
