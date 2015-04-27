using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Requests data from cache.
	/// </summary>
	[Command(ProtocolName.CacheStorage.RequestEntries)]
	public class RequestEntriesCommand
	{
		/// <summary>
		/// Gets or sets ID of cache to get entries from.
		/// </summary>
		public string CacheId { get; set; }
		/// <summary>
		/// Gets or sets Number of records to skip.
		/// </summary>
		public long SkipCount { get; set; }
		/// <summary>
		/// Gets or sets Number of records to fetch.
		/// </summary>
		public long PageSize { get; set; }
	}
}
