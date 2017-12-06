using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	[SupportedBy("Chrome")]
	public class TouchPoint
	{
		/// <summary>
		/// Gets or sets X coordinate of the event relative to the main frame's viewport in CSS pixels.
		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate of the event relative to the main frame's viewport in CSS pixels. 0 refers to the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.
		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Gets or sets X radius of the touch area (default: 1).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? RadiusX { get; set; }
		/// <summary>
		/// Gets or sets Y radius of the touch area (default: 1).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? RadiusY { get; set; }
		/// <summary>
		/// Gets or sets Rotation angle (default: 0.0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double RotationAngle { get; set; }
		/// <summary>
		/// Gets or sets Force (default: 1.0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Force { get; set; }
		/// <summary>
		/// Gets or sets Identifier used to track touch sources between events, must be unique within an event.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Id { get; set; }
	}
}
