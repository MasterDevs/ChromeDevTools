using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Encoding options for a screenshot.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ScreenshotParams
	{
		/// <summary>
		/// Gets or sets Image compression format (defaults to png).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Format { get; set; }
		/// <summary>
		/// Gets or sets Compression quality from range [0..100] (jpeg only).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Quality { get; set; }
	}
}
