using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Sets breakpoint on AsyncOperation callback handler.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetAsyncOperationBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetAsyncOperationBreakpointCommandResponse
	{
	}
}
