using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Steps out of the function call.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.StepOut)]
	public class StepOutCommandResponse
	{
	}
}
