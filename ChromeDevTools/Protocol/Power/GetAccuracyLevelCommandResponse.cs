using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// Describes the accuracy level of the data provider.
	/// </summary>
	[CommandResponse(ProtocolName.Power.GetAccuracyLevel)]
	public class GetAccuracyLevelCommandResponse
	{
		/// <summary>
		/// Gets or sets Result
		/// </summary>
		public string Result { get; set; }
	}
}
