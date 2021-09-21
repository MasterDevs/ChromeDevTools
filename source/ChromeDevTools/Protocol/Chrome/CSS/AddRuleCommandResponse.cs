using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Inserts a new rule with the given `ruleText` in a stylesheet with given `styleSheetId`, at the
	/// position specified by `location`.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.AddRule)]
	[SupportedBy("Chrome")]
	public class AddRuleCommandResponse
	{
		/// <summary>
		/// Gets or sets The newly created rule.
		/// </summary>
		public CSSRule Rule { get; set; }
	}
}
