using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Disables animation domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
