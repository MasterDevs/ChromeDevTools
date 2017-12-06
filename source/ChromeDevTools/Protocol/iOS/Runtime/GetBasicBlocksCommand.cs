using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Returns a list of basic blocks for the given sourceID with information about their text ranges and whether or not they have executed.
	/// </summary>
	[Command(ProtocolName.Runtime.GetBasicBlocks)]
	[SupportedBy("iOS")]
	public class GetBasicBlocksCommand: ICommand<GetBasicBlocksCommandResponse>
	{
		/// <summary>
		/// Gets or sets Indicates which sourceID information is requested for.
		/// </summary>
		public string SourceID { get; set; }
	}
}
