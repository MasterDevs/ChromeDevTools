using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Dispatches a mouse event to the page.
	/// </summary>
	[Command(ProtocolName.Input.DispatchMouseEvent)]
	[SupportedBy("Chrome")]
	public class DispatchMouseEventCommand: ICommand<DispatchMouseEventCommandResponse>
	{
		/// <summary>
		/// Gets or sets Type of the mouse event.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets X coordinate of the event relative to the main frame's viewport in CSS pixels.
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate of the event relative to the main frame's viewport in CSS pixels. 0 refers to the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.
		/// </summary>
		public double Y { get; set; }
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
		/// <summary>
		/// Gets or sets Mouse button (default: "none").
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Button { get; set; }
		/// <summary>
		/// Gets or sets Number of times the mouse button was clicked (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ClickCount { get; set; }
		/// <summary>
		/// Gets or sets X delta in CSS pixels for mouse wheel event (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DeltaX { get; set; }
		/// <summary>
		/// Gets or sets Y delta in CSS pixels for mouse wheel event (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DeltaY { get; set; }
	}
}
