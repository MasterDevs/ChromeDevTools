using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns the resulting bitmap.
	/// </summary>
	[Command(ProtocolName.LayerTree.ReplaySnapshot)]
	[SupportedBy("Chrome")]
	public class ReplaySnapshotCommand: ICommand<ReplaySnapshotCommandResponse>
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
		/// <summary>
		/// Gets or sets The first step to replay from (replay from the very start if not specified).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? FromStep { get; set; }
		/// <summary>
		/// Gets or sets The last step to replay to (replay till the end if not specified).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ToStep { get; set; }
		/// <summary>
		/// Gets or sets The scale to apply while replaying (defaults to 1).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Scale { get; set; }
	}
}
