using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Cache identifier.
	/// </summary>
	public class Cache
	{
		/// <summary>
		/// Gets or sets An opaque unique id of the cache.
		/// </summary>
		public string CacheId { get; set; }
		/// <summary>
		/// Gets or sets Security origin of the cache.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets The name of the cache.
		/// </summary>
		public string CacheName { get; set; }
	}
}
