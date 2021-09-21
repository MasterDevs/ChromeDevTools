using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Stop tracking rule usage and return the list of rules that were used since last call to
	/// `takeCoverageDelta` (or since start of coverage instrumentation)
	/// </summary>
	[CommandResponse(ProtocolName.CSS.StopRuleUsageTracking)]
	[SupportedBy("Chrome")]
	public class StopRuleUsageTrackingCommandResponse
	{
		/// <summary>
		/// Gets or sets RuleUsage
		/// </summary>
		public RuleUsage[] RuleUsage { get; set; }
	}
}
