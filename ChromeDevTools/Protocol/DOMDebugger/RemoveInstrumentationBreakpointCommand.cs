using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular native event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveInstrumentationBreakpoint)]
	public class RemoveInstrumentationBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Instrumentation name to stop on.
		/// </summary>
		public string EventName { get; set; }
	}
}
