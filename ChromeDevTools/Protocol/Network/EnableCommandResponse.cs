using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Enables network tracking, network events will now be delivered to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Network.Enable)]
	public class EnableCommandResponse
	{
	}
}
