using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Generic font families collection.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FontFamilies
	{
		/// <summary>
		/// Gets or sets The standard font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Standard { get; set; }
		/// <summary>
		/// Gets or sets The fixed font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Fixed { get; set; }
		/// <summary>
		/// Gets or sets The serif font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Serif { get; set; }
		/// <summary>
		/// Gets or sets The sansSerif font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SansSerif { get; set; }
		/// <summary>
		/// Gets or sets The cursive font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Cursive { get; set; }
		/// <summary>
		/// Gets or sets The fantasy font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Fantasy { get; set; }
		/// <summary>
		/// Gets or sets The pictograph font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Pictograph { get; set; }
	}
}
