using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Tells whether emulation of network conditions is supported.
	/// </summary>
	[Command(ProtocolName.Network.CanEmulateNetworkConditions)]
	public class CanEmulateNetworkConditionsCommand
	{
	}
}
