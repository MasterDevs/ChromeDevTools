using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Disables page domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
