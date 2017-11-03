using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Requests cache names.
	/// </summary>
	[Command(ProtocolName.CacheStorage.RequestCacheNames)]
	[SupportedBy("Chrome")]
	public class RequestCacheNamesCommand: ICommand<RequestCacheNamesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
	}
}
