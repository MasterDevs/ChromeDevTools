using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Removes JavaScript breakpoint.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.RemoveBreakpoint)]
	public class RemoveBreakpointCommandResponse
	{
	}
}
