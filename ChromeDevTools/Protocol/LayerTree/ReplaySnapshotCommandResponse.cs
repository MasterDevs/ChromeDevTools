using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns the resulting bitmap.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.ReplaySnapshot)]
	public class ReplaySnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets A data: URL for resulting image.
		/// </summary>
		public string DataURL { get; set; }
	}
}
