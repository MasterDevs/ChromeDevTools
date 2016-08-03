using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Data entry.
	/// </summary>
	[SupportedBy("Chrome")]
	public class DataEntry
	{
		/// <summary>
		/// Gets or sets JSON-stringified request object.
		/// </summary>
		public string Request { get; set; }
		/// <summary>
		/// Gets or sets JSON-stringified response object.
		/// </summary>
		public string Response { get; set; }
	}
}
