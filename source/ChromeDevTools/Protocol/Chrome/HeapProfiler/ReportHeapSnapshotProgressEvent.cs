using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Event(ProtocolName.HeapProfiler.ReportHeapSnapshotProgress)]
	[SupportedBy("Chrome")]
	public class ReportHeapSnapshotProgressEvent
	{
		/// <summary>
		/// Gets or sets Done
		/// </summary>
		public long Done { get; set; }
		/// <summary>
		/// Gets or sets Total
		/// </summary>
		public long Total { get; set; }
		/// <summary>
		/// Gets or sets Finished
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Finished { get; set; }
	}
}
