using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Activates emulation of network conditions.
	/// </summary>
	[CommandResponse(ProtocolName.Network.EmulateNetworkConditions)]
	public class EmulateNetworkConditionsCommandResponse
	{
	}
}
