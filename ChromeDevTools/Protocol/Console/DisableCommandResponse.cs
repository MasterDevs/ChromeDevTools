using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Disables console domain, prevents further console messages from being reported to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Console.Disable)]
	public class DisableCommandResponse
	{
	}
}
