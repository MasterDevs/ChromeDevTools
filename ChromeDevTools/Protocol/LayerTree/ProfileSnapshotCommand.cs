using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.LayerTree
{
	[Command(ProtocolName.LayerTree.ProfileSnapshot)]
	public class ProfileSnapshotCommand
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
		/// <summary>
		/// Gets or sets The maximum number of times to replay the snapshot (1, if not specified).
		/// </summary>
		public long MinRepeatCount { get; set; }
		/// <summary>
		/// Gets or sets The minimum duration (in seconds) to replay the snapshot.
		/// </summary>
		public double MinDuration { get; set; }
		/// <summary>
		/// Gets or sets The clip rectangle to apply when replaying the snapshot.
		/// </summary>
		public DOM.Rect ClipRect { get; set; }
	}
}
