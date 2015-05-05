using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Enables or disables async call stacks tracking.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetAsyncCallStackDepth)]
	public class SetAsyncCallStackDepthCommandResponse
	{
	}
}
