using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Removes JavaScript breakpoint.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.RemoveBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveBreakpointCommandResponse
	{
	}
}
