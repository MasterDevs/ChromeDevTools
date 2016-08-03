using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Power
{
	/// <summary>
	/// Tells whether power profiling is supported.
	/// </summary>
	[Command(ProtocolName.Power.CanProfilePower)]
	[SupportedBy("Chrome")]
	public class CanProfilePowerCommand
	{
	}
}
