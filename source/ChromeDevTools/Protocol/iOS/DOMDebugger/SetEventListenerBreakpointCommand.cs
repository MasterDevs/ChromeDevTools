using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular DOM event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetEventListenerBreakpoint)]
	[SupportedBy("iOS")]
	public class SetEventListenerBreakpointCommand: ICommand<SetEventListenerBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets DOM Event name to stop on (any DOM event will do).
		/// </summary>
		public string EventName { get; set; }
	}
}
