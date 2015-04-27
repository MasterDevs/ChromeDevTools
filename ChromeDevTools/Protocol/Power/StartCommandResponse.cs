using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// Start power events collection.
	/// </summary>
	[CommandResponse(ProtocolName.Power.Start)]
	public class StartCommandResponse
	{
	}
}
