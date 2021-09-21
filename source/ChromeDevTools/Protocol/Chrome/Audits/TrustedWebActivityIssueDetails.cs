using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class TrustedWebActivityIssueDetails
	{
		/// <summary>
		/// Gets or sets The url that triggers the violation.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets ViolationType
		/// </summary>
		public TwaQualityEnforcementViolationType ViolationType { get; set; }
		/// <summary>
		/// Gets or sets HttpStatusCode
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? HttpStatusCode { get; set; }
		/// <summary>
		/// Gets or sets The package name of the Trusted Web Activity client app. This field is
		/// only used when violation type is kDigitalAssetLinks.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PackageName { get; set; }
		/// <summary>
		/// Gets or sets The signature of the Trusted Web Activity client app. This field is only
		/// used when violation type is kDigitalAssetLinks.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Signature { get; set; }
	}
}
