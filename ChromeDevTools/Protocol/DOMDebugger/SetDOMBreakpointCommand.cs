using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular operation with DOM.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetDOMBreakpoint)]
	public class SetDOMBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the node to set breakpoint on.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Type of the operation to stop upon.
		/// </summary>
		public DOMBreakpointType Type { get; set; }
	}
}
