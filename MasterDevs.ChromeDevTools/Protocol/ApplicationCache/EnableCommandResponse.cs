using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Enables application cache domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.ApplicationCache.Enable)]
	public class EnableCommandResponse
	{
	}
}
