using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetOuterHTML)]
	public class GetOuterHTMLCommandResponse
	{
		/// <summary>
		/// Gets or sets Outer HTML markup.
		/// </summary>
		public string OuterHTML { get; set; }
	}
}
