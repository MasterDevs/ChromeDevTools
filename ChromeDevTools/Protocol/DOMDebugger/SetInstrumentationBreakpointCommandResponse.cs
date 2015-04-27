using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular native event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetInstrumentationBreakpoint)]
	public class SetInstrumentationBreakpointCommandResponse
	{
	}
}
