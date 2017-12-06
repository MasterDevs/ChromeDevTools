using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular DOM event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetEventListenerBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetEventListenerBreakpointCommand: ICommand<SetEventListenerBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets DOM Event name to stop on (any DOM event will do).
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// Gets or sets EventTarget interface name to stop on. If equal to <code>"*"</code> or not provided, will stop on any EventTarget.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetName { get; set; }
	}
}
