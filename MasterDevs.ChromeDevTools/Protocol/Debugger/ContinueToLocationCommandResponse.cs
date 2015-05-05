using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Continues execution until specific location is reached.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.ContinueToLocation)]
	public class ContinueToLocationCommandResponse
	{
	}
}
