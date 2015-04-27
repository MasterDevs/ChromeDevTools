using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Activates emulation of network conditions.
	/// </summary>
	[CommandResponse(ProtocolName.Network.EmulateNetworkConditions)]
	public class EmulateNetworkConditionsCommandResponse
	{
	}
}
