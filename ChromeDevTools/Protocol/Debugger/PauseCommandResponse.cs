using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Stops on the next JavaScript statement.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.Pause)]
	public class PauseCommandResponse
	{
	}
}
