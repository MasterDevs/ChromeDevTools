using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Screencast frame metadata
	/// </summary>
	public class ScreencastFrameMetadata
	{
		/// <summary>
		/// Gets or sets Top offset in DIP.
		/// </summary>
		public double OffsetTop { get; set; }
		/// <summary>
		/// Gets or sets Page scale factor.
		/// </summary>
		public double PageScaleFactor { get; set; }
		/// <summary>
		/// Gets or sets Device screen width in DIP.
		/// </summary>
		public double DeviceWidth { get; set; }
		/// <summary>
		/// Gets or sets Device screen height in DIP.
		/// </summary>
		public double DeviceHeight { get; set; }
		/// <summary>
		/// Gets or sets Position of horizontal scroll in CSS pixels.
		/// </summary>
		public double ScrollOffsetX { get; set; }
		/// <summary>
		/// Gets or sets Position of vertical scroll in CSS pixels.
		/// </summary>
		public double ScrollOffsetY { get; set; }
		/// <summary>
		/// Gets or sets Frame swap timestamp.
		/// </summary>
		public double Timestamp { get; set; }
	}
}
