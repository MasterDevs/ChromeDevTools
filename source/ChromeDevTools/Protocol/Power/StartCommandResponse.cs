using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// Start power events collection.
	/// </summary>
	[CommandResponse(ProtocolName.Power.Start)]
	public class StartCommandResponse
	{
	}
}
