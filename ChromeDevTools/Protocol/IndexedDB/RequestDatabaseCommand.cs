using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Requests database with given name in given frame.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestDatabase)]
	public class RequestDatabaseCommand
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		public string DatabaseName { get; set; }
	}
}
