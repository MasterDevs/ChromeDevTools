using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint from XMLHttpRequest.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveXHRBreakpoint)]
	public class RemoveXHRBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Resource URL substring.
		/// </summary>
		public string Url { get; set; }
	}
}
