using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular native event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetInstrumentationBreakpoint)]
	public class SetInstrumentationBreakpointCommandResponse
	{
	}
}
