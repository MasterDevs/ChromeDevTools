using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Reloads given page optionally ignoring the cache.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Reload)]
	[SupportedBy("iOS")]
	public class ReloadCommandResponse
	{
	}
}
