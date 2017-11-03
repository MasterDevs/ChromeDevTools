using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint from XMLHttpRequest.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveXHRBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveXHRBreakpointCommandResponse
	{
	}
}
