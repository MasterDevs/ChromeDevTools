using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns canvas log.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.SnapshotCommandLog)]
	[SupportedBy("Chrome")]
	public class SnapshotCommandLogCommandResponse
	{
		public class CommandLogArray
		{
		}

		/// <summary>
		/// Gets or sets The array of canvas function calls.
		/// </summary>
		public CommandLogArray[] CommandLog { get; set; }
	}
}
