using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class CrossOriginEmbedderPolicyStatus
	{
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public CrossOriginEmbedderPolicyValue Value { get; set; }
		/// <summary>
		/// Gets or sets ReportOnlyValue
		/// </summary>
		public CrossOriginEmbedderPolicyValue ReportOnlyValue { get; set; }
		/// <summary>
		/// Gets or sets ReportingEndpoint
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ReportingEndpoint { get; set; }
		/// <summary>
		/// Gets or sets ReportOnlyReportingEndpoint
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ReportOnlyReportingEndpoint { get; set; }
	}
}
