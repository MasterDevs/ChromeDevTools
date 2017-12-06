using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Activates emulation of network conditions.
	/// </summary>
	[CommandResponse(ProtocolName.Network.EmulateNetworkConditions)]
	[SupportedBy("Chrome")]
	public class EmulateNetworkConditionsCommandResponse
	{
	}
}
