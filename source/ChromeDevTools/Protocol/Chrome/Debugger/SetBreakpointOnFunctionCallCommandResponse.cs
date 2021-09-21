using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint before each call to the given function.
	/// If another function was created from the same source as a given one,
	/// calling it will also trigger the breakpoint.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetBreakpointOnFunctionCall)]
	[SupportedBy("Chrome")]
	public class SetBreakpointOnFunctionCallCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the created breakpoint for further reference.
		/// </summary>
		public string BreakpointId { get; set; }
	}
}
