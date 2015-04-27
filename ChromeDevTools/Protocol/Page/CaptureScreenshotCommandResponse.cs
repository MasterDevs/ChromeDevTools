using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Capture page screenshot.
	/// </summary>
	[CommandResponse(ProtocolName.Page.CaptureScreenshot)]
	public class CaptureScreenshotCommandResponse
	{
		/// <summary>
		/// Gets or sets Base64-encoded image data (PNG).
		/// </summary>
		public string Data { get; set; }
	}
}
