using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Inserts a new rule with the given <code>ruleText</code> in a stylesheet with given <code>styleSheetId</code>, at the position specified by <code>location</code>.
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
