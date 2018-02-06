using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Fired when user asks to capture screenshot of some area on the page.
	/// </summary>
	[Event(ProtocolName.Overlay.ScreenshotRequested)]
	[SupportedBy("Chrome")]
	public class ScreenshotRequestedEvent
	{
		/// <summary>
		/// Gets or sets Viewport to capture, in CSS.
		/// </summary>
		public Page.Viewport Viewport { get; set; }
	}
}
