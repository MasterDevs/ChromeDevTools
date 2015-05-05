using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets node HTML markup, returns new node id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetOuterHTML)]
	public class SetOuterHTMLCommandResponse
	{
	}
}
