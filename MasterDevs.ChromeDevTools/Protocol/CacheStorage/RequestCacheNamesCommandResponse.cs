using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Requests cache names.
	/// </summary>
	[CommandResponse(ProtocolName.CacheStorage.RequestCacheNames)]
	public class RequestCacheNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets Caches for the security origin.
		/// </summary>
		public Cache[] Caches { get; set; }
	}
}
