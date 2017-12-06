using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	/// Fired for every instrumentation event while timeline is started.
	/// </summary>
	[Event(ProtocolName.Timeline.EventRecorded)]
	[SupportedBy("iOS")]
	public class EventRecordedEvent
	{
		/// <summary>
		/// Gets or sets Timeline event record data.
		/// </summary>
		public TimelineEvent Record { get; set; }
	}
}
