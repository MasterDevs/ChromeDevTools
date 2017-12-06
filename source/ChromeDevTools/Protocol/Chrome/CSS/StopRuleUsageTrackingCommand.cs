using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// The list of rules with an indication of whether these were used
	/// </summary>
	[Command(ProtocolName.CSS.StopRuleUsageTracking)]
	[SupportedBy("Chrome")]
	public class StopRuleUsageTrackingCommand: ICommand<StopRuleUsageTrackingCommandResponse>
	{
	}
}
