using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Requests data from object store or index.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestData)]
	public class RequestDataCommand
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Gets or sets Object store name.
		/// </summary>
		public string ObjectStoreName { get; set; }
		/// <summary>
		/// Gets or sets Index name, empty string for object store data requests.
		/// </summary>
		public string IndexName { get; set; }
		/// <summary>
		/// Gets or sets Number of records to skip.
		/// </summary>
		public long SkipCount { get; set; }
		/// <summary>
		/// Gets or sets Number of records to fetch.
		/// </summary>
		public long PageSize { get; set; }
		/// <summary>
		/// Gets or sets Key range.
		/// </summary>
		public KeyRange KeyRange { get; set; }
	}
}
