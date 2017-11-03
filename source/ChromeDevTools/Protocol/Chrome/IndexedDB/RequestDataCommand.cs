using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Requests data from object store or index.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestData)]
	[SupportedBy("Chrome")]
	public class RequestDataCommand: ICommand<RequestDataCommandResponse>
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
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public KeyRange KeyRange { get; set; }
	}
}
