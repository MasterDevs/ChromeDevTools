using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Activates / deactivates all breakpoints on the page.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetBreakpointsActive)]
	[SupportedBy("Chrome")]
	public class SetBreakpointsActiveCommandResponse
	{
	}
}
