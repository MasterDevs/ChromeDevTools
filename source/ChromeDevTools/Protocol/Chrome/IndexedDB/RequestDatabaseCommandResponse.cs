using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Requests database with given name in given frame.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.RequestDatabase)]
	[SupportedBy("Chrome")]
	public class RequestDatabaseCommandResponse
	{
		/// <summary>
		/// Gets or sets Database with an array of object stores.
		/// </summary>
		public DatabaseWithObjectStores DatabaseWithObjectStores { get; set; }
	}
}
