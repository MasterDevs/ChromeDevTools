using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Applies specified style edits one after another in the given order.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetStyleTexts)]
	[SupportedBy("Chrome")]
	public class SetStyleTextsCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting styles after modification.
		/// </summary>
		public CSSStyle[] Styles { get; set; }
	}
}
