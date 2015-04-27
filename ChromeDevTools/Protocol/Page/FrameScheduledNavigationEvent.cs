using ChromeDevTools;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when frame schedules a potential navigation.
	/// </summary>
	[Event(ProtocolName.Page.FrameScheduledNavigation)]
	public class FrameScheduledNavigationEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has scheduled a navigation.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Delay (in seconds) until the navigation is scheduled to begin. The navigation is not guaranteed to start.
		/// </summary>
		public double Delay { get; set; }
	}
}
