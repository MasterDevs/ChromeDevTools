using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint from XMLHttpRequest.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveXHRBreakpoint)]
	public class RemoveXHRBreakpointCommandResponse
	{
	}
}
