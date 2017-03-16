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
		/// Gets or sets Request url spec.
		/// </summary>
		public string Request { get; set; }
		/// <summary>
		/// Gets or sets Response stataus text.
		/// </summary>
		public string Response { get; set; }
	}
}
