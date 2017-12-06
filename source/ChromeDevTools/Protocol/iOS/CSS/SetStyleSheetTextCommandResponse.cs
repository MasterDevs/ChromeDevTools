using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Sets the new stylesheet text, thereby invalidating all existing <code>CSSStyleId</code>'s and <code>CSSRuleId</code>'s contained by this stylesheet.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetStyleSheetText)]
	[SupportedBy("iOS")]
	public class SetStyleSheetTextCommandResponse
	{
	}
}
