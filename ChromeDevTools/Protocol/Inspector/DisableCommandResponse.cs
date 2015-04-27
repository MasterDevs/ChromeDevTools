using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Inspector
{
	/// <summary>
	/// Disables inspector domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Inspector.Disable)]
	public class DisableCommandResponse
	{
	}
}
