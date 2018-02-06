using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Enables the selector recording.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.StartRuleUsageTracking)]
	[SupportedBy("Chrome")]
	public class StartRuleUsageTrackingCommandResponse
	{
	}
}
