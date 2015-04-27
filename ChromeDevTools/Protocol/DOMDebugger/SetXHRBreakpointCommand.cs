using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on XMLHttpRequest.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetXHRBreakpoint)]
	public class SetXHRBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Resource URL substring. All XHRs having this substring in the URL will get stopped upon.
		/// </summary>
		public string Url { get; set; }
	}
}
