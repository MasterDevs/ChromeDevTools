using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Emulates touch event from the mouse event parameters.
	/// </summary>
	[Command(ProtocolName.Input.EmulateTouchFromMouseEvent)]
	public class EmulateTouchFromMouseEventCommand
	{
		/// <summary>
		/// Gets or sets Type of the mouse event.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets X coordinate of the mouse pointer in DIP.
		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate of the mouse pointer in DIP.
		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Gets or sets Time at which the event occurred. Measured in UTC time in seconds since January 1, 1970.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Mouse button.
		/// </summary>
		public string Button { get; set; }
		/// <summary>
		/// Gets or sets X delta in DIP for mouse wheel event (default: 0).
		/// </summary>
		public double DeltaX { get; set; }
		/// <summary>
		/// Gets or sets Y delta in DIP for mouse wheel event (default: 0).
		/// </summary>
		public double DeltaY { get; set; }
		/// <summary>
		/// Gets or sets Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8 (default: 0).
		/// </summary>
		public long Modifiers { get; set; }
		/// <summary>
		/// Gets or sets Number of times the mouse button was clicked (default: 0).
		/// </summary>
		public long ClickCount { get; set; }
	}
}
