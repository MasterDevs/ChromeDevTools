using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at a given location.
	/// </summary>
	[Command(ProtocolName.Debugger.SetBreakpoint)]
	public class SetBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Location to set breakpoint in.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// Gets or sets Expression to use as a breakpoint condition. When specified, debugger will only stop on the breakpoint if this expression evaluates to true.
		/// </summary>
		public string Condition { get; set; }
	}
}
