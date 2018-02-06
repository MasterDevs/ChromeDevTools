using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Fired when frame schedules a potential navigation.
	/// </summary>
	[Event(ProtocolName.Page.FrameScheduledNavigation)]
	[SupportedBy("iOS")]
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
