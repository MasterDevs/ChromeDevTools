using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular native event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveInstrumentationBreakpoint)]
	public class RemoveInstrumentationBreakpointCommandResponse
	{
	}
}
