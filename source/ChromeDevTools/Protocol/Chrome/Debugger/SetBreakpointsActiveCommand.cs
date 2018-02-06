using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Activates / deactivates all breakpoints on the page.
	/// </summary>
	[Command(ProtocolName.Debugger.SetBreakpointsActive)]
	[SupportedBy("Chrome")]
	public class SetBreakpointsActiveCommand: ICommand<SetBreakpointsActiveCommandResponse>
	{
		/// <summary>
		/// Gets or sets New value for breakpoints active state.
		/// </summary>
		public bool Active { get; set; }
	}
}
