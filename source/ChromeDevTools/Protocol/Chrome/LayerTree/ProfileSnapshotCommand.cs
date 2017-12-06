using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	[Command(ProtocolName.LayerTree.ProfileSnapshot)]
	[SupportedBy("Chrome")]
	public class ProfileSnapshotCommand: ICommand<ProfileSnapshotCommandResponse>
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
		/// <summary>
		/// Gets or sets The maximum number of times to replay the snapshot (1, if not specified).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MinRepeatCount { get; set; }
		/// <summary>
		/// Gets or sets The minimum duration (in seconds) to replay the snapshot.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double MinDuration { get; set; }
		/// <summary>
		/// Gets or sets The clip rectangle to apply when replaying the snapshot.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.Rect ClipRect { get; set; }
	}
}
