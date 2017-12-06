using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	/// <summary>
	/// If heap objects tracking has been started then backend regularly sends a current value for last seen object id and corresponding timestamp. If the were changes in the heap since last event then one or more heapStatsUpdate events will be sent before a new lastSeenObjectId event.
	/// </summary>
	[Event(ProtocolName.HeapProfiler.LastSeenObjectId)]
	[SupportedBy("Chrome")]
	public class LastSeenObjectIdEvent
	{
		/// <summary>
		/// Gets or sets LastSeenObjectId
		/// </summary>
		public long LastSeenObjectId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}
