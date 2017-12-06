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
		/// Gets or sets Request URL.
		/// </summary>
		public string RequestURL { get; set; }
		/// <summary>
		/// Gets or sets Request method.
		/// </summary>
		public string RequestMethod { get; set; }
		/// <summary>
		/// Gets or sets Request headers
		/// </summary>
		public Header[] RequestHeaders { get; set; }
		/// <summary>
		/// Gets or sets Number of seconds since epoch.
		/// </summary>
		public double ResponseTime { get; set; }
		/// <summary>
		/// Gets or sets HTTP response status code.
		/// </summary>
		public long ResponseStatus { get; set; }
		/// <summary>
		/// Gets or sets HTTP response status text.
		/// </summary>
		public string ResponseStatusText { get; set; }
		/// <summary>
		/// Gets or sets Response headers
		/// </summary>
		public Header[] ResponseHeaders { get; set; }
	}
}
