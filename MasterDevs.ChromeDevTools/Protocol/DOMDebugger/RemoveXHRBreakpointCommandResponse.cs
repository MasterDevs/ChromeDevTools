using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint from XMLHttpRequest.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveXHRBreakpoint)]
	public class RemoveXHRBreakpointCommandResponse
	{
	}
}
