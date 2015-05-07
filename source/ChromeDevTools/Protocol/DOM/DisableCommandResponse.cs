using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Disables DOM agent for the given page.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Disable)]
	public class DisableCommandResponse
	{
	}
}
