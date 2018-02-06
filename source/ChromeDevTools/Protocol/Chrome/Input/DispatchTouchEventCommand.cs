using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
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
		/// Gets or sets Type of the touch event. TouchEnd and TouchCancel must not contain any touch points, while TouchStart and TouchMove must contains at least one.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Active touch points on the touch device. One event per any changed point (compared to previous touch event in a sequence) is generated, emulating pressing/moving/releasing points one by one.
		/// </summary>
		public TouchPoint[] TouchPoints { get; set; }
		/// <summary>
		/// Gets or sets Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8 (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Modifiers { get; set; }
		/// <summary>
		/// Gets or sets Time at which the event occurred.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Timestamp { get; set; }
	}
}
