using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Removes AsyncOperation breakpoint.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.RemoveAsyncOperationBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveAsyncOperationBreakpointCommandResponse
	{
	}
}
