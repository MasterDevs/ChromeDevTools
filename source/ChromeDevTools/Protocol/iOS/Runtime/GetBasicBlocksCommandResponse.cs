using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Returns a list of basic blocks for the given sourceID with information about their text ranges and whether or not they have executed.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetBasicBlocks)]
	[SupportedBy("iOS")]
	public class GetBasicBlocksCommandResponse
	{
		/// <summary>
		/// Gets or sets BasicBlocks
		/// </summary>
		public BasicBlock[] BasicBlocks { get; set; }
	}
}
