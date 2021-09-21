using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Sends a BeginFrame to the target and returns when the frame was completed. Optionally captures a
	/// screenshot from the resulting frame. Requires that the target was created with enabled
	/// BeginFrameControl. Designed for use with --run-all-compositor-stages-before-draw, see also
	/// https://goo.gl/3zHXhB for more background.
	/// </summary>
	[CommandResponse(ProtocolName.HeadlessExperimental.BeginFrame)]
	[SupportedBy("Chrome")]
	public class BeginFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets Whether the BeginFrame resulted in damage and, thus, a new frame was committed to the
		/// display. Reported for diagnostic uses, may be removed in the future.
		/// </summary>
		public bool HasDamage { get; set; }
		/// <summary>
		/// Gets or sets Base64-encoded image data of the screenshot, if one was requested and successfully taken. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ScreenshotData { get; set; }
	}
}
