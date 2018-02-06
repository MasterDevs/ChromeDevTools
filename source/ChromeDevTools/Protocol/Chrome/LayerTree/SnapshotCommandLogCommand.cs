using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns canvas log.
	/// </summary>
	[Command(ProtocolName.LayerTree.SnapshotCommandLog)]
	[SupportedBy("Chrome")]
	public class SnapshotCommandLogCommand: ICommand<SnapshotCommandLogCommandResponse>
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
