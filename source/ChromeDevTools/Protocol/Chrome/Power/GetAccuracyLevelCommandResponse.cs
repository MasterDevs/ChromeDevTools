using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Power
{
	/// <summary>
	/// Describes the accuracy level of the data provider.
	/// </summary>
	[CommandResponse(ProtocolName.Power.GetAccuracyLevel)]
	[SupportedBy("Chrome")]
	public class GetAccuracyLevelCommandResponse
	{
		/// <summary>
		/// Gets or sets Result
		/// </summary>
		public string Result { get; set; }
	}
}
