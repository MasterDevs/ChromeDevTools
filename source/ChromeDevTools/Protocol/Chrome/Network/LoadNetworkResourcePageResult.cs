using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// An object providing the result of a network resource load.
	/// </summary>
	[SupportedBy("Chrome")]
	public class LoadNetworkResourcePageResult
	{
		/// <summary>
		/// Gets or sets Success
		/// </summary>
		public bool Success { get; set; }
		/// <summary>
		/// Gets or sets Optional values used for error reporting.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double NetError { get; set; }
		/// <summary>
		/// Gets or sets NetErrorName
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string NetErrorName { get; set; }
		/// <summary>
		/// Gets or sets HttpStatusCode
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double HttpStatusCode { get; set; }
		/// <summary>
		/// Gets or sets If successful, one of the following two fields holds the result.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Stream { get; set; }
		/// <summary>
		/// Gets or sets Response headers.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> Headers { get; set; }
	}
}
