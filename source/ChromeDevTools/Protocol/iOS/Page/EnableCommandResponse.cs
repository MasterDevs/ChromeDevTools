using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Enables page domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommandResponse
	{
	}
}
