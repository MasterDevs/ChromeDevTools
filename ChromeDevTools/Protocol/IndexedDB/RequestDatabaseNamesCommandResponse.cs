using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Requests database names for given security origin.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.RequestDatabaseNames)]
	public class RequestDatabaseNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets Database names for origin.
		/// </summary>
		public string[] DatabaseNames { get; set; }
	}
}
