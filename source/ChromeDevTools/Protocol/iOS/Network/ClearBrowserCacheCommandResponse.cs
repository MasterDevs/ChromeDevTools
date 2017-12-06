using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>
	[CommandResponse(ProtocolName.Network.ClearBrowserCache)]
	[SupportedBy("iOS")]
	public class ClearBrowserCacheCommandResponse
	{
	}
}
