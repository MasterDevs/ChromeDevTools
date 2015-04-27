using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Dispatches a touch event to the page.
	/// </summary>
	[Command(ProtocolName.Input.DispatchTouchEvent)]
	public class DispatchTouchEventCommand
	{
		/// <summary>
		/// Gets or sets Type of the touch event.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Touch points.
		/// </summary>
		public TouchPoint[] TouchPoints { get; set; }
		/// <summary>
		/// Gets or sets Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8 (default: 0).
		/// </summary>
		public long Modifiers { get; set; }
		/// <summary>
		/// Gets or sets Time at which the event occurred. Measured in UTC time in seconds since January 1, 1970 (default: current time).
		/// </summary>
		public double Timestamp { get; set; }
	}
}
