using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Default font sizes.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FontSizes
	{
		/// <summary>
		/// Gets or sets Default standard font size.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Standard { get; set; }
		/// <summary>
		/// Gets or sets Default fixed font size.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Fixed { get; set; }
	}
}
