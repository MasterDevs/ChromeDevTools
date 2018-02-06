using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>
	[CommandResponse(ProtocolName.Network.ClearBrowserCache)]
	[SupportedBy("Chrome")]
	public class ClearBrowserCacheCommandResponse
	{
	}
}
