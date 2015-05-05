using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// Describes the accuracy level of the data provider.
	/// </summary>
	[Command(ProtocolName.Power.GetAccuracyLevel)]
	public class GetAccuracyLevelCommand
	{
	}
}
