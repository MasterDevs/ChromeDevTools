using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when a navigation is started if navigation throttles are enabled.  The navigation will be deferred until processNavigation is called.
	/// </summary>
	[Event(ProtocolName.Page.NavigationRequested)]
	[SupportedBy("Chrome")]
	public class NavigationRequestedEvent
	{
		/// <summary>
		/// Gets or sets Whether the navigation is taking place in the main frame or in a subframe.
		/// </summary>
		public bool IsInMainFrame { get; set; }
		/// <summary>
		/// Gets or sets Whether the navigation has encountered a server redirect or not.
		/// </summary>
		public bool IsRedirect { get; set; }
		/// <summary>
		/// Gets or sets NavigationId
		/// </summary>
		public long NavigationId { get; set; }
		/// <summary>
		/// Gets or sets URL of requested navigation.
		/// </summary>
		public string Url { get; set; }
	}
}
