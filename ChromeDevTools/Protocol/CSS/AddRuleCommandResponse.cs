using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Inserts a new rule with the given <code>ruleText</code> in a stylesheet with given <code>styleSheetId</code>, at the position specified by <code>location</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.AddRule)]
	public class AddRuleCommandResponse
	{
		/// <summary>
		/// Gets or sets The newly created rule.
		/// </summary>
		public CSSRule Rule { get; set; }
	}
}
