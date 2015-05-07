using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint)]
	public class RemoveEventListenerBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Event name.
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// Gets or sets EventTarget interface name.
		/// </summary>
		public string TargetName { get; set; }
	}
}
