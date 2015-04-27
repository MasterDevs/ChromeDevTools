using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Clears the overriden Geolocation Position and Error.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.ClearGeolocationOverride)]
	public class ClearGeolocationOverrideCommandResponse
	{
	}
}
