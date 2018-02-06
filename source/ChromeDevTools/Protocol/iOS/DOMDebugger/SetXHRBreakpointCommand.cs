using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on XMLHttpRequest.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetXHRBreakpoint)]
	[SupportedBy("iOS")]
	public class SetXHRBreakpointCommand: ICommand<SetXHRBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets Resource URL substring. All XHRs having this substring in the URL will get stopped upon.
		/// </summary>
		public string Url { get; set; }
	}
}
