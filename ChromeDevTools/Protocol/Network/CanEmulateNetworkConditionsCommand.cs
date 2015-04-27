using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Tells whether emulation of network conditions is supported.
	/// </summary>
	[Command(ProtocolName.Network.CanEmulateNetworkConditions)]
	public class CanEmulateNetworkConditionsCommand
	{
	}
}
