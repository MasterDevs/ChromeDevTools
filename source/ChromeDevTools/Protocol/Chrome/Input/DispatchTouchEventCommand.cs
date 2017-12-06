using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Dispatches a touch event to the page.
	/// </summary>
	[Command(ProtocolName.Input.DispatchTouchEvent)]
	[SupportedBy("Chrome")]
	public class DispatchTouchEventCommand: ICommand<DispatchTouchEventCommandResponse>
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
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Modifiers { get; set; }
		/// <summary>
		/// Gets or sets Time at which the event occurred. Measured in UTC time in seconds since January 1, 1970 (default: current time).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Timestamp { get; set; }
	}
}
