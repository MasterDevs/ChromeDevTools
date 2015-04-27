using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Removes AsyncOperation breakpoint.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.RemoveAsyncOperationBreakpoint)]
	public class RemoveAsyncOperationBreakpointCommandResponse
	{
	}
}
