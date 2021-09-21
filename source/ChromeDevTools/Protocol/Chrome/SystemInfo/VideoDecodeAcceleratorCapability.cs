using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Describes a supported video decoding profile with its associated minimum and
	/// maximum resolutions.
	/// </summary>
	[SupportedBy("Chrome")]
	public class VideoDecodeAcceleratorCapability
	{
		/// <summary>
		/// Gets or sets Video codec profile that is supported, e.g. VP9 Profile 2.
		/// </summary>
		public string Profile { get; set; }
		/// <summary>
		/// Gets or sets Maximum video dimensions in pixels supported for this |profile|.
		/// </summary>
		public Size MaxResolution { get; set; }
		/// <summary>
		/// Gets or sets Minimum video dimensions in pixels supported for this |profile|.
		/// </summary>
		public Size MinResolution { get; set; }
	}
}
