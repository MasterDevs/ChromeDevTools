using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Set permission settings for given origin.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.SetPermission)]
	[SupportedBy("Chrome")]
	public class SetPermissionCommandResponse
	{
	}
}
