using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.StopTrackingHeapObjects)]
	public class StopTrackingHeapObjectsCommand
	{
		/// <summary>
		/// Gets or sets If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken when the tracking is stopped.
		/// </summary>
		public bool ReportProgress { get; set; }
	}
}
