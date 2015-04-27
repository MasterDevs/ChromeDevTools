using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Activates / deactivates all breakpoints on the page.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetBreakpointsActive)]
	public class SetBreakpointsActiveCommandResponse
	{
	}
}
