using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>
	[Command(ProtocolName.CSS.SetRuleSelector)]
	[SupportedBy("iOS")]
	public class SetRuleSelectorCommand: ICommand<SetRuleSelectorCommandResponse>
	{
		/// <summary>
		/// Gets or sets RuleId
		/// </summary>
		public CSSRuleId RuleId { get; set; }
		/// <summary>
		/// Gets or sets Selector
		/// </summary>
		public string Selector { get; set; }
	}
}
