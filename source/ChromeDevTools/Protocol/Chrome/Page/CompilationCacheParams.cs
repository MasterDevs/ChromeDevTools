using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Per-script compilation cache parameters for `Page.produceCompilationCache`
	/// </summary>
	[SupportedBy("Chrome")]
	public class CompilationCacheParams
	{
		/// <summary>
		/// Gets or sets The URL of the script to produce a compilation cache entry for.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets A hint to the backend whether eager compilation is recommended.
		/// (the actual compilation mode used is upon backend discretion).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Eager { get; set; }
	}
}
