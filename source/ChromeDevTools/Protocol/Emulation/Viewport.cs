using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Visible page viewport
	/// </summary>
	public class Viewport
	{
		/// <summary>
		/// Gets or sets X scroll offset in CSS pixels.
		/// </summary>
		public double ScrollX { get; set; }
		/// <summary>
		/// Gets or sets Y scroll offset in CSS pixels.
		/// </summary>
		public double ScrollY { get; set; }
		/// <summary>
		/// Gets or sets Contents width in CSS pixels.
		/// </summary>
		public double ContentsWidth { get; set; }
		/// <summary>
		/// Gets or sets Contents height in CSS pixels.
		/// </summary>
		public double ContentsHeight { get; set; }
		/// <summary>
		/// Gets or sets Page scale factor.
		/// </summary>
		public double PageScaleFactor { get; set; }
		/// <summary>
		/// Gets or sets Minimum page scale factor.
		/// </summary>
		public double MinimumPageScaleFactor { get; set; }
		/// <summary>
		/// Gets or sets Maximum page scale factor.
		/// </summary>
		public double MaximumPageScaleFactor { get; set; }
	}
}
