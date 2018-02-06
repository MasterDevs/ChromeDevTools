using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Creates a new empty rule with the given <code>selector</code> in a stylesheet with given <code>styleSheetId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.AddRule)]
	[SupportedBy("iOS")]
	public class AddRuleCommandResponse
	{
		/// <summary>
		/// Gets or sets The newly created rule.
		/// </summary>
		public CSSRule Rule { get; set; }
	}
}
