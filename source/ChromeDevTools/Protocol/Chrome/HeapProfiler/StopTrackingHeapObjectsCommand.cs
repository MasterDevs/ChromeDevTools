using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.StopTrackingHeapObjects)]
	[SupportedBy("Chrome")]
	public class StopTrackingHeapObjectsCommand
	{
		/// <summary>
		/// Gets or sets If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken when the tracking is stopped.
		/// </summary>
		public bool ReportProgress { get; set; }
	}
}
