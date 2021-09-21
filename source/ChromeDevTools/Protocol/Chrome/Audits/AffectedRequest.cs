using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Information about a request that is affected by an inspector issue.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AffectedRequest
	{
		/// <summary>
		/// Gets or sets The unique request id.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Url
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
	}
}
