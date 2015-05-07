using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Steps into the function call.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.StepInto)]
	public class StepIntoCommandResponse
	{
	}
}
