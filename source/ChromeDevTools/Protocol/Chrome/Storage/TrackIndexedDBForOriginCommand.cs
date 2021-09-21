using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Registers origin to be notified when an update occurs to its IndexedDB.
	/// </summary>
	[Command(ProtocolName.Storage.TrackIndexedDBForOrigin)]
	[SupportedBy("Chrome")]
	public class TrackIndexedDBForOriginCommand: ICommand<TrackIndexedDBForOriginCommandResponse>
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string Origin { get; set; }
	}
}
