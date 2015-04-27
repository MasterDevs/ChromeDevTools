using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Activates / deactivates all breakpoints on the page.
	/// </summary>
	[Command(ProtocolName.Debugger.SetBreakpointsActive)]
	public class SetBreakpointsActiveCommand
	{
		/// <summary>
		/// Gets or sets New value for breakpoints active state.
		/// </summary>
		public bool Active { get; set; }
	}
}
