using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Requests cache names.
	/// </summary>
	[Command(ProtocolName.CacheStorage.RequestCacheNames)]
	public class RequestCacheNamesCommand
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
	}
}
