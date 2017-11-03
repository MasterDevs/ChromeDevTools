using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Activates / deactivates all breakpoints on the page.
	/// </summary>
	[Command(ProtocolName.Debugger.SetBreakpointsActive)]
	[SupportedBy("iOS")]
	public class SetBreakpointsActiveCommand: ICommand<SetBreakpointsActiveCommandResponse>
	{
		/// <summary>
		/// Gets or sets New value for breakpoints active state.
		/// </summary>
		public bool Active { get; set; }
	}
}
