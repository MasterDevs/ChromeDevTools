using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Tells whether emulation of network conditions is supported.
	/// </summary>
	[CommandResponse(ProtocolName.Network.CanEmulateNetworkConditions)]
	public class CanEmulateNetworkConditionsCommandResponse
	{
		/// <summary>
		/// Gets or sets True if emulation of network conditions is supported.
		/// </summary>
		public bool Result { get; set; }
	}
}
