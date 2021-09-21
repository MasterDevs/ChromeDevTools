using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular CSP violations.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetBreakOnCSPViolation)]
	[SupportedBy("Chrome")]
	public class SetBreakOnCSPViolationCommand: ICommand<SetBreakOnCSPViolationCommandResponse>
	{
		/// <summary>
		/// Gets or sets CSP Violations to stop upon.
		/// </summary>
		public string[] ViolationTypes { get; set; }
	}
}
