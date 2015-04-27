using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Requests database with given name in given frame.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.RequestDatabase)]
	public class RequestDatabaseCommandResponse
	{
		/// <summary>
		/// Gets or sets Database with an array of object stores.
		/// </summary>
		public DatabaseWithObjectStores DatabaseWithObjectStores { get; set; }
	}
}
