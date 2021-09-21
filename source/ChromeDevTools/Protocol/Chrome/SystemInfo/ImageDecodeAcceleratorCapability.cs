using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Describes a supported image decoding profile with its associated minimum and
	/// maximum resolutions and subsampling.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ImageDecodeAcceleratorCapability
	{
		/// <summary>
		/// Gets or sets Image coded, e.g. Jpeg.
		/// </summary>
		public ImageType ImageType { get; set; }
		/// <summary>
		/// Gets or sets Maximum supported dimensions of the image in pixels.
		/// </summary>
		public Size MaxDimensions { get; set; }
		/// <summary>
		/// Gets or sets Minimum supported dimensions of the image in pixels.
		/// </summary>
		public Size MinDimensions { get; set; }
		/// <summary>
		/// Gets or sets Optional array of supported subsampling formats, e.g. 4:2:0, if known.
		/// </summary>
		public SubsamplingFormat[] Subsamplings { get; set; }
	}
}
