using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Continues execution until specific location is reached.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.ContinueToLocation)]
	[SupportedBy("iOS")]
	public class ContinueToLocationCommandResponse
	{
	}
}
