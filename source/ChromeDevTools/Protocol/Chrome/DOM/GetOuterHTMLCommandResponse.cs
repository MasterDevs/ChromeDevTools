using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetOuterHTML)]
	[SupportedBy("Chrome")]
	public class GetOuterHTMLCommandResponse
	{
		/// <summary>
		/// Gets or sets Outer HTML markup.
		/// </summary>
		public string OuterHTML { get; set; }
	}
}
