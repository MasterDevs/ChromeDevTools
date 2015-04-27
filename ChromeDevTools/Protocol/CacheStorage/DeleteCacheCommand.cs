using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Deletes a cache.
	/// </summary>
	[Command(ProtocolName.CacheStorage.DeleteCache)]
	public class DeleteCacheCommand
	{
		/// <summary>
		/// Gets or sets Id of cache for deletion.
		/// </summary>
		public string CacheId { get; set; }
	}
}
