using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Grant specific permissions to the given origin and reject all others.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.GrantPermissions)]
	[SupportedBy("Chrome")]
	public class GrantPermissionsCommandResponse
	{
	}
}
