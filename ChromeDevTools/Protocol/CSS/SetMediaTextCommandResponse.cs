using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetMediaText)]
	public class SetMediaTextCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting CSS media rule after modification.
		/// </summary>
		public CSSMedia Media { get; set; }
	}
}
