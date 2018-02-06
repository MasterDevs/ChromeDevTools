using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns stylesheet data for the specified <code>styleSheetId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetStyleSheet)]
	[SupportedBy("iOS")]
	public class GetStyleSheetCommandResponse
	{
		/// <summary>
		/// Gets or sets Stylesheet contents for the specified <code>styleSheetId</code>.
		/// </summary>
		public CSSStyleSheetBody StyleSheet { get; set; }
	}
}
