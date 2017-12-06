using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Registers origin to be notified when an update occurs to its cache storage list.
	/// </summary>
	[Command(ProtocolName.Storage.TrackCacheStorageForOrigin)]
	[SupportedBy("Chrome")]
	public class TrackCacheStorageForOriginCommand: ICommand<TrackCacheStorageForOriginCommandResponse>
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string Origin { get; set; }
	}
}
