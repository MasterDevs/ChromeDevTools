using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Enables debugger for the given page. Clients should not assume that the debugging has been enabled until the result for this command is received.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
