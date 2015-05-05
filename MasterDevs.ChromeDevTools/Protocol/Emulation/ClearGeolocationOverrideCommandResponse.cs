using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Clears the overriden Geolocation Position and Error.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.ClearGeolocationOverride)]
	public class ClearGeolocationOverrideCommandResponse
	{
	}
}
