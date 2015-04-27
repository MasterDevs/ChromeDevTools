using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Sets breakpoint on AsyncOperation callback handler.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetAsyncOperationBreakpoint)]
	public class SetAsyncOperationBreakpointCommandResponse
	{
	}
}
