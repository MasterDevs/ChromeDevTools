using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Enables the CSS agent for the given page. Clients should not assume that the CSS agent has been enabled until the result of this command is received.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommandResponse
	{
	}
}
