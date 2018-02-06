using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Synthesizes a scroll gesture over a time period by issuing appropriate touch events.
	/// </summary>
	[Command(ProtocolName.Input.SynthesizeScrollGesture)]
	[SupportedBy("Chrome")]
	public class SynthesizeScrollGestureCommand: ICommand<SynthesizeScrollGestureCommandResponse>
	{
		/// <summary>
		/// Gets or sets X coordinate of the start of the gesture in CSS pixels.
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate of the start of the gesture in CSS pixels.
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Gets or sets The distance to scroll along the X axis (positive to scroll left).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double XDistance { get; set; }
		/// <summary>
		/// Gets or sets The distance to scroll along the Y axis (positive to scroll up).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double YDistance { get; set; }
		/// <summary>
		/// Gets or sets The number of additional pixels to scroll back along the X axis, in addition to the given distance.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double XOverscroll { get; set; }
		/// <summary>
		/// Gets or sets The number of additional pixels to scroll back along the Y axis, in addition to the given distance.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double YOverscroll { get; set; }
		/// <summary>
		/// Gets or sets Prevent fling (default: true).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? PreventFling { get; set; }
		/// <summary>
		/// Gets or sets Swipe speed in pixels per second (default: 800).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Speed { get; set; }
		/// <summary>
		/// Gets or sets Which type of input events to be generated (default: 'default', which queries the platform for the preferred input type).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string GestureSourceType { get; set; }
		/// <summary>
		/// Gets or sets The number of times to repeat the gesture (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? RepeatCount { get; set; }
		/// <summary>
		/// Gets or sets The number of milliseconds delay between each repeat. (default: 250).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? RepeatDelayMs { get; set; }
		/// <summary>
		/// Gets or sets The name of the interaction markers to generate, if not empty (default: "").
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InteractionMarkerName { get; set; }
	}
}
