using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Requests cache names.
	/// </summary>
	[CommandResponse(ProtocolName.CacheStorage.RequestCacheNames)]
	[SupportedBy("Chrome")]
	public class RequestCacheNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets Caches for the security origin.
		/// </summary>
		public Cache[] Caches { get; set; }
	}
}
