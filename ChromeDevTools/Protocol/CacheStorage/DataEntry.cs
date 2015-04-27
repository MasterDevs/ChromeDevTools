using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Data entry.
	/// </summary>
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
