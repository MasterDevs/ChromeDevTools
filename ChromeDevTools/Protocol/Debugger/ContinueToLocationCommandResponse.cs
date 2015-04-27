using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Continues execution until specific location is reached.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.ContinueToLocation)]
	public class ContinueToLocationCommandResponse
	{
	}
}
