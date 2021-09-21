using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Post data entry for HTTP request
	/// </summary>
	[SupportedBy("Chrome")]
	public class PostDataEntry
	{
		/// <summary>
		/// Gets or sets Bytes
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Bytes { get; set; }
	}
}
