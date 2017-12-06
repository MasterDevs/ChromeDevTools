using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Enables the selector recording.
	/// </summary>
	[Command(ProtocolName.CSS.StartRuleUsageTracking)]
	[SupportedBy("Chrome")]
	public class StartRuleUsageTrackingCommand: ICommand<StartRuleUsageTrackingCommandResponse>
	{
	}
}
