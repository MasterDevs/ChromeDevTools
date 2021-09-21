using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Unregisters origin from receiving notifications for IndexedDB.
	/// </summary>
	[Command(ProtocolName.Storage.UntrackIndexedDBForOrigin)]
	[SupportedBy("Chrome")]
	public class UntrackIndexedDBForOriginCommand: ICommand<UntrackIndexedDBForOriginCommandResponse>
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string Origin { get; set; }
	}
}
