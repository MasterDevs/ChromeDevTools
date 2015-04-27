using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Lists all positions where step-in is possible for a current statement in a specified call frame
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetStepInPositions)]
	public class GetStepInPositionsCommandResponse
	{
		/// <summary>
		/// Gets or sets experimental
		/// </summary>
		public Location[] StepInPositions { get; set; }
	}
}
