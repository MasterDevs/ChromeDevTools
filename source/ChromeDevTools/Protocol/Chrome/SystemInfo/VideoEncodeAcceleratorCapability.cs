using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Describes a supported video encoding profile with its associated maximum
	/// resolution and maximum framerate.
	/// </summary>
	[SupportedBy("Chrome")]
	public class VideoEncodeAcceleratorCapability
	{
		/// <summary>
		/// Gets or sets Video codec profile that is supported, e.g H264 Main.
		/// </summary>
		public string Profile { get; set; }
		/// <summary>
		/// Gets or sets Maximum video dimensions in pixels supported for this |profile|.
		/// </summary>
		public Size MaxResolution { get; set; }
		/// <summary>
		/// Gets or sets Maximum encoding framerate in frames per second supported for this
		/// |profile|, as fraction's numerator and denominator, e.g. 24/1 fps,
		/// 24000/1001 fps, etc.
		/// </summary>
		public long MaxFramerateNumerator { get; set; }
		/// <summary>
		/// Gets or sets MaxFramerateDenominator
		/// </summary>
		public long MaxFramerateDenominator { get; set; }
	}
}
