using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Overrides the values of device screen dimensions (window.screen.width, window.screen.height, window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media query results).
	/// </summary>
	[Command(ProtocolName.Page.SetDeviceMetricsOverride)]
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
		/// Gets or sets Whether to emulate mobile device. This includes viewport meta tag, overlay scrollbars, text autosizing and more.
		/// </summary>
		public bool Mobile { get; set; }
		/// <summary>
		/// Gets or sets Scale to apply to resulting view image. Ignored in |fitWindow| mode.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Scale { get; set; }
		/// <summary>
		/// Gets or sets Overriding screen width value in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ScreenWidth { get; set; }
		/// <summary>
		/// Gets or sets Overriding screen height value in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ScreenHeight { get; set; }
		/// <summary>
		/// Gets or sets Overriding view X position on screen in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? PositionX { get; set; }
		/// <summary>
		/// Gets or sets Overriding view Y position on screen in pixels (minimum 0, maximum 10000000). Only used for |mobile==true|.
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
		public Emulation.ScreenOrientation ScreenOrientation { get; set; }
	}
}
