using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular native event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveInstrumentationBreakpoint)]
	[SupportedBy("iOS")]
	public class RemoveInstrumentationBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Instrumentation name to stop on.
		/// </summary>
		public string EventName { get; set; }
	}
}
