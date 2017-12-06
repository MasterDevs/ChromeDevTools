using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Steps out of the function call.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.StepOut)]
	[SupportedBy("Chrome")]
	public class StepOutCommandResponse
	{
	}
}
