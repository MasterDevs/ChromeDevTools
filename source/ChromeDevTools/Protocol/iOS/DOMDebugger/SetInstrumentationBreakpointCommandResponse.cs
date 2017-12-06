using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular native event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetInstrumentationBreakpoint)]
	[SupportedBy("iOS")]
	public class SetInstrumentationBreakpointCommandResponse
	{
	}
}
