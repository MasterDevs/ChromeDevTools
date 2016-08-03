using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Lists all positions where step-in is possible for a current statement in a specified call frame
	/// </summary>
	[Command(ProtocolName.Debugger.GetStepInPositions)]
	[SupportedBy("Chrome")]
	public class GetStepInPositionsCommand
	{
		/// <summary>
		/// Gets or sets Id of a call frame where the current statement should be analized
		/// </summary>
		public string CallFrameId { get; set; }
	}
}
