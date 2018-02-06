using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Disables domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
