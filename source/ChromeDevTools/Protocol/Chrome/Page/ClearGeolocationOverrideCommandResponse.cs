using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears the overriden Geolocation Position and Error.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ClearGeolocationOverride)]
	[SupportedBy("Chrome")]
	public class ClearGeolocationOverrideCommandResponse
	{
	}
}
