using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Enables DOM agent for the given page.
	/// </summary>
	[Command(ProtocolName.DOM.Enable)]
	public class EnableCommand
	{
	}
}
