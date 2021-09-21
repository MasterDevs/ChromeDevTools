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
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate of the event relative to the main frame's viewport in CSS pixels. 0 refers to
		/// the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Gets or sets X radius of the touch area (default: 1.0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double RadiusX { get; set; }
		/// <summary>
		/// Gets or sets Y radius of the touch area (default: 1.0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double RadiusY { get; set; }
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
		/// Gets or sets The normalized tangential pressure, which has a range of [-1,1] (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double TangentialPressure { get; set; }
		/// <summary>
		/// Gets or sets The plane angle between the Y-Z plane and the plane containing both the stylus axis and the Y axis, in degrees of the range [-90,90], a positive tiltX is to the right (default: 0)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? TiltX { get; set; }
		/// <summary>
		/// Gets or sets The plane angle between the X-Z plane and the plane containing both the stylus axis and the X axis, in degrees of the range [-90,90], a positive tiltY is towards the user (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? TiltY { get; set; }
		/// <summary>
		/// Gets or sets The clockwise rotation of a pen stylus around its own major axis, in degrees in the range [0,359] (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Twist { get; set; }
		/// <summary>
		/// Gets or sets Identifier used to track touch sources between events, must be unique within an event.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Id { get; set; }
	}
}
