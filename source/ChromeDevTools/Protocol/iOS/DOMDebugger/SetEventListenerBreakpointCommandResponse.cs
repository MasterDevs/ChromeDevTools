using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular DOM event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetEventListenerBreakpoint)]
	[SupportedBy("iOS")]
	public class SetEventListenerBreakpointCommandResponse
	{
	}
}
