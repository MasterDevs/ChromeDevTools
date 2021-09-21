using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Requests data from cache.
	/// </summary>
	[CommandResponse(ProtocolName.CacheStorage.RequestEntries)]
	[SupportedBy("Chrome")]
	public class RequestEntriesCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of object store data entries.
		/// </summary>
		public DataEntry[] CacheDataEntries { get; set; }
		/// <summary>
		/// Gets or sets Count of returned entries from this storage. If pathFilter is empty, it
		/// is the count of all entries from this storage.
		/// </summary>
		public double ReturnCount { get; set; }
	}
}
