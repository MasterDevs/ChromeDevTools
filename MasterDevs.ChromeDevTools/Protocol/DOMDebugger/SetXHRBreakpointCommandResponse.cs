using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on XMLHttpRequest.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetXHRBreakpoint)]
	public class SetXHRBreakpointCommandResponse
	{
	}
}
