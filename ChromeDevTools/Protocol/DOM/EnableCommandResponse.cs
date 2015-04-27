using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Enables DOM agent for the given page.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Enable)]
	public class EnableCommandResponse
	{
	}
}
