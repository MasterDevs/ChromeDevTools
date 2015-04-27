using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.StartTrackingHeapObjects)]
	public class StartTrackingHeapObjectsCommand
	{
		/// <summary>
		/// Gets or sets TrackAllocations
		/// </summary>
		public bool TrackAllocations { get; set; }
	}
}
