using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Capture page screenshot.
	/// </summary>
	[Command(ProtocolName.Page.CaptureScreenshot)]
	[SupportedBy("Chrome")]
	public class CaptureScreenshotCommand
	{
		/// <summary>
		/// Gets or sets Image compression format (defaults to png).
		/// </summary>
		public string Format { get; set; }
		/// <summary>
		/// Gets or sets Compression quality from range [0..100] (jpeg only).
		/// </summary>
		public long Quality { get; set; }
	}
}
