using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Removes JavaScript breakpoint.
	/// </summary>
	[Command(ProtocolName.Debugger.RemoveBreakpoint)]
	public class RemoveBreakpointCommand
	{
		/// <summary>
		/// Gets or sets BreakpointId
		/// </summary>
		public string BreakpointId { get; set; }
	}
}
