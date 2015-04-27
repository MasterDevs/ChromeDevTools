using ChromeDevTools;

namespace ChromeDevTools.Protocol.Timeline
{
	/// <summary>
	/// Deprecated.
	/// </summary>
	[Event(ProtocolName.Timeline.EventRecorded)]
	public class EventRecordedEvent
	{
		/// <summary>
		/// Gets or sets Timeline event record data.
		/// </summary>
		public TimelineEvent Record { get; set; }
	}
}
