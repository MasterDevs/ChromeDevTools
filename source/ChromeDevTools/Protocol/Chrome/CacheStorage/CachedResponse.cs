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
		/// Gets or sets Entry content, base64-encoded.
		/// </summary>
		public string Body { get; set; }
	}
}
