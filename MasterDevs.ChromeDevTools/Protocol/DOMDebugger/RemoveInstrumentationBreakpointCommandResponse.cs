using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular native event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveInstrumentationBreakpoint)]
	public class RemoveInstrumentationBreakpointCommandResponse
	{
	}
}
