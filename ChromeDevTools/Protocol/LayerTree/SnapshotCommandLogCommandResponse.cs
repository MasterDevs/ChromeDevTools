using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns canvas log.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.SnapshotCommandLog)]
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
