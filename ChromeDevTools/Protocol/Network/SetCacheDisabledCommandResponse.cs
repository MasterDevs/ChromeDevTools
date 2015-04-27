using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Toggles ignoring cache for each request. If <code>true</code>, cache will not be used.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetCacheDisabled)]
	public class SetCacheDisabledCommandResponse
	{
	}
}
