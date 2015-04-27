using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Returns the layer snapshot identifier.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.MakeSnapshot)]
	public class MakeSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
