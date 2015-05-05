using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Clears the overriden Geolocation Position and Error.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ClearGeolocationOverride)]
	public class ClearGeolocationOverrideCommandResponse
	{
	}
}
