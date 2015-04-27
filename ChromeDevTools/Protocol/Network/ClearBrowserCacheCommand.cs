using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>
	[Command(ProtocolName.Network.ClearBrowserCache)]
	public class ClearBrowserCacheCommand
	{
	}
}
