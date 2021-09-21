using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Stops observing for sinks and issues.
	/// </summary>
	[CommandResponse(ProtocolName.Cast.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
