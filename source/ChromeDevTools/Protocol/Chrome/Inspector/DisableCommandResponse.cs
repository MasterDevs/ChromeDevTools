using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Inspector
{
	/// <summary>
	/// Disables inspector domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Inspector.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
