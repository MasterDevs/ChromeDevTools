using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetRuleSelector)]
	[SupportedBy("Chrome")]
	public class SetRuleSelectorCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting selector list after modification.
		/// </summary>
		public SelectorList SelectorList { get; set; }
	}
}
