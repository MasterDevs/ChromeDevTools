using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides the values of device screen dimensions (window.screen.width, window.screen.height,
	/// window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media
	/// query results).
	/// </summary>
	[Command(ProtocolName.Emulation.SetDeviceMetricsOverride)]
	[SupportedBy("Chrome")]
	public class SetDeviceMetricsOverrideCommand: ICommand<SetDeviceMetricsOverrideCommandResponse>
	{
		/// <summary>
		/// Gets or sets Overriding width value in pixels (minimum 0, maximum 10000000). 0 disables the override.
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Gets or sets Overriding height value in pixels (minimum 0, maximum 10000000). 0 disables the override.
		/// </summary>
		public long Height { get; set; }
		/// <summary>
		/// Gets or sets Overriding device scale factor value. 0 disables the override.
		/// </summary>
		public double DeviceScaleFactor { get; set; }
		/// <summary>
		/// Gets or sets Whether to emulate mobile device. This includes viewport meta tag, overlay scrollbars, text
		/// autosizing and more.
		/// </summary>
		public bool Mobile { get; set; }
		/// <summary>
		/// Gets or sets Scale to apply to resulting view image.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Scale { get; set; }
		/// <summary>
		/// Gets or sets Overriding screen width value in pixels (minimum 0, maximum 10000000).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ScreenWidth { get; set; }
		/// <summary>
		/// Gets or sets Overriding screen height value in pixels (minimum 0, maximum 10000000).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ScreenHeight { get; set; }
		/// <summary>
		/// Gets or sets Overriding view X position on screen in pixels (minimum 0, maximum 10000000).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? PositionX { get; set; }
		/// <summary>
		/// Gets or sets Overriding view Y position on screen in pixels (minimum 0, maximum 10000000).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? PositionY { get; set; }
		/// <summary>
		/// Gets or sets Do not set visible view size, rely upon explicit setVisibleSize call.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DontSetVisibleSize { get; set; }
		/// <summary>
		/// Gets or sets Screen orientation override.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ScreenOrientation ScreenOrientation { get; set; }
		/// <summary>
		/// Gets or sets If set, the visible area of the page will be overridden to this viewport. This viewport
		/// change is not observed by the page, e.g. viewport-relative elements do not change positions.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Page.Viewport Viewport { get; set; }
		/// <summary>
		/// Gets or sets If set, the display feature of a multi-segment screen. If not set, multi-segment support
		/// is turned-off.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DisplayFeature DisplayFeature { get; set; }
	}
}
