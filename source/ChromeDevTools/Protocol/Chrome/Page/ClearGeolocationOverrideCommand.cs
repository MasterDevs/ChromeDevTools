using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears the overridden Geolocation Position and Error.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Page.ClearGeolocationOverride)]
	[SupportedBy("Chrome")]
	public class ClearGeolocationOverrideCommand: ICommand<ClearGeolocationOverrideCommandResponse>
	{
	}
}
