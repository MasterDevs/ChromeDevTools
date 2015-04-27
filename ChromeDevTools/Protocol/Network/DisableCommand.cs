using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Disables network tracking, prevents network events from being sent to the client.
	/// </summary>
	[Command(ProtocolName.Network.Disable)]
	public class DisableCommand
	{
	}
}
