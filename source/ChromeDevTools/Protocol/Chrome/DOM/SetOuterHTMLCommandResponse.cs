using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets node HTML markup, returns new node id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetOuterHTML)]
	[SupportedBy("Chrome")]
	public class SetOuterHTMLCommandResponse
	{
	}
}
