using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when a new window is going to be opened, via window.open(), link click, form submission,
	/// etc.
	/// </summary>
	[Event(ProtocolName.Page.WindowOpen)]
	[SupportedBy("Chrome")]
	public class WindowOpenEvent
	{
		/// <summary>
		/// Gets or sets The URL for the new window.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Window name.
		/// </summary>
		public string WindowName { get; set; }
		/// <summary>
		/// Gets or sets An array of enabled window features.
		/// </summary>
		public string[] WindowFeatures { get; set; }
		/// <summary>
		/// Gets or sets Whether or not it was triggered by user gesture.
		/// </summary>
		public bool UserGesture { get; set; }
	}
}
