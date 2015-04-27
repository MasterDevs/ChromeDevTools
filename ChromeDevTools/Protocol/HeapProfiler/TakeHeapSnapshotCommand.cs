using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.TakeHeapSnapshot)]
	public class TakeHeapSnapshotCommand
	{
		/// <summary>
		/// Gets or sets If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken.
		/// </summary>
		public bool ReportProgress { get; set; }
	}
}
