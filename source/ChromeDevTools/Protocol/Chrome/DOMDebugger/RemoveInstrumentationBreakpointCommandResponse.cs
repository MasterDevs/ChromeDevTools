using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular native event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveInstrumentationBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveInstrumentationBreakpointCommandResponse
	{
	}
}
