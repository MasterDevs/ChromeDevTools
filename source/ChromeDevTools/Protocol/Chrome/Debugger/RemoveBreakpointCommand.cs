using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Removes JavaScript breakpoint.
	/// </summary>
	[Command(ProtocolName.Debugger.RemoveBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveBreakpointCommand: ICommand<RemoveBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets BreakpointId
		/// </summary>
		public string BreakpointId { get; set; }
	}
}
