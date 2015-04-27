using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Enables application cache domain notifications.
	/// </summary>
	[Command(ProtocolName.ApplicationCache.Enable)]
	public class EnableCommand
	{
	}
}
