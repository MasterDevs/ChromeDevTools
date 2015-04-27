using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes DOM breakpoint that was set using <code>setDOMBreakpoint</code>.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveDOMBreakpoint)]
	public class RemoveDOMBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the node to remove breakpoint from.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Type of the breakpoint to remove.
		/// </summary>
		public DOMBreakpointType Type { get; set; }
	}
}
