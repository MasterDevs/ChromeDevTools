using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Returns the snapshot identifier.
	/// </summary>
	[Command(ProtocolName.LayerTree.LoadSnapshot)]
	public class LoadSnapshotCommand
	{
		/// <summary>
		/// Gets or sets An array of tiles composing the snapshot.
		/// </summary>
		public PictureTile[] Tiles { get; set; }
	}
}
