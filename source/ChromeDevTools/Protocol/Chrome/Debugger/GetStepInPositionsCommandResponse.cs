using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Lists all positions where step-in is possible for a current statement in a specified call frame
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetStepInPositions)]
	[SupportedBy("Chrome")]
	public class GetStepInPositionsCommandResponse
	{
		/// <summary>
		/// Gets or sets experimental
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Location[] StepInPositions { get; set; }
	}
}
