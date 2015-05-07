using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Returns the snapshot identifier.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.LoadSnapshot)]
	public class LoadSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets The id of the snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
