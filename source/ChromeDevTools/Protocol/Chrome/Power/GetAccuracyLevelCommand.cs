using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Power
{
	/// <summary>
	/// Describes the accuracy level of the data provider.
	/// </summary>
	[Command(ProtocolName.Power.GetAccuracyLevel)]
	[SupportedBy("Chrome")]
	public class GetAccuracyLevelCommand
	{
	}
}
