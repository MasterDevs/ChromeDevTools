using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns the resulting bitmap.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.ReplaySnapshot)]
	[SupportedBy("Chrome")]
	public class ReplaySnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets A data: URL for resulting image.
		/// </summary>
		public string DataURL { get; set; }
	}
}
