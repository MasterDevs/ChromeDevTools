using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Tells whether clearing browser cache is supported.
	/// </summary>
	[Command(ProtocolName.Network.CanClearBrowserCache)]
	public class CanClearBrowserCacheCommand
	{
	}
}
