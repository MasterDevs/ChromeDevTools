using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes DOM breakpoint that was set using <code>setDOMBreakpoint</code>.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveDOMBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveDOMBreakpointCommandResponse
	{
	}
}
