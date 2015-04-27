using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// HTTP request data.
	/// </summary>
	public class Request
	{
		/// <summary>
		/// Gets or sets Request URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets HTTP request method.
		/// </summary>
		public string Method { get; set; }
		/// <summary>
		/// Gets or sets HTTP request headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// Gets or sets HTTP POST request data.
		/// </summary>
		public string PostData { get; set; }
	}
}
