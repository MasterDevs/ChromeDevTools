using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Steps into the function call.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.StepInto)]
	[SupportedBy("iOS")]
	public class StepIntoCommandResponse
	{
	}
}
