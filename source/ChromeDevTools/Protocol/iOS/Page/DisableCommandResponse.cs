using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Disables page domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommandResponse
	{
	}
}
