using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Invoke custom browser commands used by telemetry.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.ExecuteBrowserCommand)]
	[SupportedBy("Chrome")]
	public class ExecuteBrowserCommandCommandResponse
	{
	}
}
