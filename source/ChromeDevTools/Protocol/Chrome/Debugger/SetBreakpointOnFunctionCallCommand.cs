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
	[Command(ProtocolName.Debugger.SetBreakpointOnFunctionCall)]
	[SupportedBy("Chrome")]
	public class SetBreakpointOnFunctionCallCommand: ICommand<SetBreakpointOnFunctionCallCommandResponse>
	{
		/// <summary>
		/// Gets or sets Function object id.
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Expression to use as a breakpoint condition. When specified, debugger will
		/// stop on the breakpoint if this expression evaluates to true.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Condition { get; set; }
	}
}
