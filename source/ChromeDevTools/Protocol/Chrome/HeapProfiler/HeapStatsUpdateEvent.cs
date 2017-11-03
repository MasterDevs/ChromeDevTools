using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	/// <summary>
	/// If heap objects tracking has been started then backend may send update for one or more fragments
	/// </summary>
	[Event(ProtocolName.HeapProfiler.HeapStatsUpdate)]
	[SupportedBy("Chrome")]
	public class HeapStatsUpdateEvent
	{
		/// <summary>
		/// Gets or sets An array of triplets. Each triplet describes a fragment. The first integer is the fragment index, the second integer is a total count of objects for the fragment, the third integer is a total size of the objects for the fragment.
		/// </summary>
		public long[] StatsUpdate { get; set; }
	}
}
