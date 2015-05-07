using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Clears the overriden Geolocation Position and Error.
	/// </summary>
	[Command(ProtocolName.Emulation.ClearGeolocationOverride)]
	public class ClearGeolocationOverrideCommand
	{
	}
}
