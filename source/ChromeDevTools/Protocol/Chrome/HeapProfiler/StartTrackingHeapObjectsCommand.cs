using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.StartTrackingHeapObjects)]
	[SupportedBy("Chrome")]
	public class StartTrackingHeapObjectsCommand: ICommand<StartTrackingHeapObjectsCommandResponse>
	{
		/// <summary>
		/// Gets or sets TrackAllocations
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? TrackAllocations { get; set; }
	}
}
