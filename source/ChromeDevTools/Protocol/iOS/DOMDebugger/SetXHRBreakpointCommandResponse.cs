using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on XMLHttpRequest.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetXHRBreakpoint)]
	[SupportedBy("iOS")]
	public class SetXHRBreakpointCommandResponse
	{
	}
}
