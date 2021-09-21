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
	[Command(ProtocolName.HeadlessExperimental.BeginFrame)]
	[SupportedBy("Chrome")]
	public class BeginFrameCommand: ICommand<BeginFrameCommandResponse>
	{
		/// <summary>
		/// Gets or sets Timestamp of this BeginFrame in Renderer TimeTicks (milliseconds of uptime). If not set,
		/// the current time will be used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double FrameTimeTicks { get; set; }
		/// <summary>
		/// Gets or sets The interval between BeginFrames that is reported to the compositor, in milliseconds.
		/// Defaults to a 60 frames/second interval, i.e. about 16.666 milliseconds.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Interval { get; set; }
		/// <summary>
		/// Gets or sets Whether updates should not be committed and drawn onto the display. False by default. If
		/// true, only side effects of the BeginFrame will be run, such as layout and animations, but
		/// any visual updates may not be visible on the display or in screenshots.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? NoDisplayUpdates { get; set; }
		/// <summary>
		/// Gets or sets If set, a screenshot of the frame will be captured and returned in the response. Otherwise,
		/// no screenshot will be captured. Note that capturing a screenshot can fail, for example,
		/// during renderer initialization. In such a case, no screenshot data will be returned.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ScreenshotParams Screenshot { get; set; }
	}
}
