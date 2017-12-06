using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetMediaText)]
	[SupportedBy("Chrome")]
	public class SetMediaTextCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting CSS media rule after modification.
		/// </summary>
		public CSSMedia Media { get; set; }
	}
}
