using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// Tells whether power profiling is supported.
	/// </summary>
	[Command(ProtocolName.Power.CanProfilePower)]
	public class CanProfilePowerCommand
	{
	}
}
