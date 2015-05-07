using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[Event(ProtocolName.HeapProfiler.ReportHeapSnapshotProgress)]
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
		public bool Finished { get; set; }
	}
}
