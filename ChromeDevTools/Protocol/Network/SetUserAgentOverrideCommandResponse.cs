using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Allows overriding user agent with the given string.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetUserAgentOverride)]
	public class SetUserAgentOverrideCommandResponse
	{
	}
}
