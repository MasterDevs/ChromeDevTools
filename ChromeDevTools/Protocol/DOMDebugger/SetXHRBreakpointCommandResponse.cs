using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on XMLHttpRequest.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetXHRBreakpoint)]
	public class SetXHRBreakpointCommandResponse
	{
	}
}
