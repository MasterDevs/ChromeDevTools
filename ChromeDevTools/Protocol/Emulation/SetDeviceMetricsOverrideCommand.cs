using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Overrides the values of device screen dimensions (window.screen.width, window.screen.height, window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media query results).
	/// </summary>
	[Command(ProtocolName.Emulation.SetDeviceMetricsOverride)]
	public class SetDeviceMetricsOverrideCommand
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
		/// Gets or sets Whether a view that exceeds the available browser window area should be scaled down to fit.
		/// </summary>
		public bool FitWindow { get; set; }
		/// <summary>
		/// Gets or sets Scale to apply to resulting view image. Ignored in |fitWindow| mode.
		/// </summary>
		public double Scale { get; set; }
		/// <summary>
		/// Gets or sets X offset to shift resulting view image by. Ignored in |fitWindow| mode.
		/// </summary>
		public double OffsetX { get; set; }
		/// <summary>
		/// Gets or sets Y offset to shift resulting view image by. Ignored in |fitWindow| mode.
		/// </summary>
		public double OffsetY { get; set; }
	}
}
