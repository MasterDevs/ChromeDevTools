using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes DOM breakpoint that was set using <code>setDOMBreakpoint</code>.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveDOMBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveDOMBreakpointCommand: ICommand<RemoveDOMBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the node to remove breakpoint from.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Type of the breakpoint to remove.
		/// </summary>
		public string Type { get; set; }
	}
}
