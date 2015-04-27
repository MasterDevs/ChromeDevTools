using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes DOM breakpoint that was set using <code>setDOMBreakpoint</code>.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveDOMBreakpoint)]
	public class RemoveDOMBreakpointCommandResponse
	{
	}
}
