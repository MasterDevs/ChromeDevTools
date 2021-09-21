using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Reset all permission management for all origins.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.ResetPermissions)]
	[SupportedBy("Chrome")]
	public class ResetPermissionsCommandResponse
	{
	}
}
