using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Pauses page execution. Can be resumed using generic Runtime.runIfWaitingForDebugger.
	/// </summary>
	[CommandResponse(ProtocolName.Page.WaitForDebugger)]
	[SupportedBy("Chrome")]
	public class WaitForDebuggerCommandResponse
	{
	}
}
