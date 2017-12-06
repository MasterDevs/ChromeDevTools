using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when the page with currently enabled screencast was shown or hidden </code>.
	/// </summary>
	[Event(ProtocolName.Page.ScreencastVisibilityChanged)]
	[SupportedBy("Chrome")]
	public class ScreencastVisibilityChangedEvent
	{
		/// <summary>
		/// Gets or sets True if the page is visible.
		/// </summary>
		public bool Visible { get; set; }
	}
}
