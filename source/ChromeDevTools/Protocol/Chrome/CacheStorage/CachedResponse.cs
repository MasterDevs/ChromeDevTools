using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Cached response
	/// </summary>
	[SupportedBy("Chrome")]
	public class CachedResponse
	{
		/// <summary>
		/// Gets or sets Entry content, base64-encoded. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string Body { get; set; }
	}
}
