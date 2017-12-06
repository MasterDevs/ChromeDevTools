using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Returns the snapshot identifier.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.LoadSnapshot)]
	[SupportedBy("Chrome")]
	public class LoadSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets The id of the snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
