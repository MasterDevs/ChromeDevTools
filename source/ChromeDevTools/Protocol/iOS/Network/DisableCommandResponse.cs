using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Disables network tracking, prevents network events from being sent to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Network.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommandResponse
	{
	}
}
