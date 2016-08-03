using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Power
{
	/// <summary>
	/// Start power events collection.
	/// </summary>
	[Command(ProtocolName.Power.Start)]
	[SupportedBy("Chrome")]
	public class StartCommand
	{
	}
}
