using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Inspector
{
	/// <summary>
	/// Enables inspector domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Inspector.Enable)]
	public class EnableCommandResponse
	{
	}
}
