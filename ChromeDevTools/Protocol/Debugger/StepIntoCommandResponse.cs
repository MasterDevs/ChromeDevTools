using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Steps into the function call.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.StepInto)]
	public class StepIntoCommandResponse
	{
	}
}
