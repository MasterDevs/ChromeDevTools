using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at a given location.
	/// </summary>
	[Command(ProtocolName.Debugger.SetBreakpoint)]
	[SupportedBy("iOS")]
	public class SetBreakpointCommand: ICommand<SetBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets Location to set breakpoint in.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// Gets or sets Options to apply to this breakpoint to modify its behavior.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BreakpointOptions Options { get; set; }
	}
}
