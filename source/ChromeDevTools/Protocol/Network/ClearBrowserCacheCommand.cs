using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>
	[Command(ProtocolName.Network.ClearBrowserCache)]
	public class ClearBrowserCacheCommand
	{
	}
}
