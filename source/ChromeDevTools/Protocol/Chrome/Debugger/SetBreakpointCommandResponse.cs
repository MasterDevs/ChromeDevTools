using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at a given location.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetBreakpointCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the created breakpoint for further reference.
		/// </summary>
		public string BreakpointId { get; set; }
		/// <summary>
		/// Gets or sets Location this breakpoint resolved into.
		/// </summary>
		public Location ActualLocation { get; set; }
	}
}
