using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Reloads given page optionally ignoring the cache.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Reload)]
	public class ReloadCommandResponse
	{
	}
}
