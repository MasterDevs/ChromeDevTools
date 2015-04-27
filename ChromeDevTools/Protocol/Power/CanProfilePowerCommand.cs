using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// Tells whether power profiling is supported.
	/// </summary>
	[Command(ProtocolName.Power.CanProfilePower)]
	public class CanProfilePowerCommand
	{
	}
}
