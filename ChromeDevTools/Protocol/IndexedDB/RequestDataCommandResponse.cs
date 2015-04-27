using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Requests data from object store or index.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.RequestData)]
	public class RequestDataCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of object store data entries.
		/// </summary>
		public DataEntry[] ObjectStoreDataEntries { get; set; }
		/// <summary>
		/// Gets or sets If true, there are more entries to fetch in the given range.
		/// </summary>
		public bool HasMore { get; set; }
	}
}
