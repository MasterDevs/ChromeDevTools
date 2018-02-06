using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Steps out of the function call.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.StepOut)]
	[SupportedBy("iOS")]
	public class StepOutCommandResponse
	{
	}
}
