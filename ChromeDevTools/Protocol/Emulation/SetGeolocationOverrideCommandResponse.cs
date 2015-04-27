using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position unavailable.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetGeolocationOverride)]
	public class SetGeolocationOverrideCommandResponse
	{
	}
}
