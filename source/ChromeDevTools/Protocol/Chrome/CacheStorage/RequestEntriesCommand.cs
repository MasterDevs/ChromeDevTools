using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Requests data from cache.
	/// </summary>
	[Command(ProtocolName.CacheStorage.RequestEntries)]
	[SupportedBy("Chrome")]
	public class RequestEntriesCommand: ICommand<RequestEntriesCommandResponse>
	{
		/// <summary>
		/// Gets or sets ID of cache to get entries from.
		/// </summary>
		public string CacheId { get; set; }
		/// <summary>
		/// Gets or sets Number of records to skip.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? SkipCount { get; set; }
		/// <summary>
		/// Gets or sets Number of records to fetch.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? PageSize { get; set; }
		/// <summary>
		/// Gets or sets If present, only return the entries containing this substring in the path
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PathFilter { get; set; }
	}
}
