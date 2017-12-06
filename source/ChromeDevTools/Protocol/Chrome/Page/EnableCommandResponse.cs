using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Enables page domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
