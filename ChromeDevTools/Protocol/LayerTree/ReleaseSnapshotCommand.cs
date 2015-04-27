using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Releases layer snapshot captured by the back-end.
	/// </summary>
	[Command(ProtocolName.LayerTree.ReleaseSnapshot)]
	public class ReleaseSnapshotCommand
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
