using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Enables application cache domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.ApplicationCache.Enable)]
	public class EnableCommandResponse
	{
	}
}
