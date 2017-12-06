using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Enables network tracking, network events will now be delivered to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Network.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
