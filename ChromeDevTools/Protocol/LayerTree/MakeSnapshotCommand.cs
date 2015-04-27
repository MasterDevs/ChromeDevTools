using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Returns the layer snapshot identifier.
	/// </summary>
	[Command(ProtocolName.LayerTree.MakeSnapshot)]
	public class MakeSnapshotCommand
	{
		/// <summary>
		/// Gets or sets The id of the layer.
		/// </summary>
		public string LayerId { get; set; }
	}
}
