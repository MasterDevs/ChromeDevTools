using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Steps over the statement.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.StepOver)]
	[SupportedBy("iOS")]
	public class StepOverCommandResponse
	{
	}
}
