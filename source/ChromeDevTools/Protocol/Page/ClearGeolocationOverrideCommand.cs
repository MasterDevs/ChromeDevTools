using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Clears the overriden Geolocation Position and Error.
	/// </summary>
	[Command(ProtocolName.Page.ClearGeolocationOverride)]
	public class ClearGeolocationOverrideCommand
	{
	}
}
