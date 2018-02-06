using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	/// Disables console domain, prevents further console messages from being reported to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Console.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
