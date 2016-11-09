using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Timeline
{
	/// <summary>
	/// Deprecated.
	/// </summary>
	[Event(ProtocolName.Timeline.EventRecorded)]
	[SupportedBy("Chrome")]
	public class EventRecordedEvent
	{
		/// <summary>
		/// Gets or sets Timeline event record data.
		/// </summary>
		public TimelineEvent Record { get; set; }
	}
}
