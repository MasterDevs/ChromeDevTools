using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint)]
	public class RemoveEventListenerBreakpointCommandResponse
	{
	}
}
