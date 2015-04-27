using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular DOM event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetEventListenerBreakpoint)]
	public class SetEventListenerBreakpointCommand
	{
		/// <summary>
		/// Gets or sets DOM Event name to stop on (any DOM event will do).
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// Gets or sets EventTarget interface name to stop on. If equal to <code>"*"</code> or not provided, will stop on any EventTarget.
		/// </summary>
		public string TargetName { get; set; }
	}
}
