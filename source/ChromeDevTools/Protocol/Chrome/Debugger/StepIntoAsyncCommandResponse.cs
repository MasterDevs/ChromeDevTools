using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Steps into the first async operation handler that was scheduled by or after the current statement.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.StepIntoAsync)]
	[SupportedBy("Chrome")]
	public class StepIntoAsyncCommandResponse
	{
	}
}
