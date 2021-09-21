using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class ContentSecurityPolicyIssueDetails
	{
		/// <summary>
		/// Gets or sets The url not included in allowed sources.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BlockedURL { get; set; }
		/// <summary>
		/// Gets or sets Specific directive that is violated, causing the CSP issue.
		/// </summary>
		public string ViolatedDirective { get; set; }
		/// <summary>
		/// Gets or sets IsReportOnly
		/// </summary>
		public bool IsReportOnly { get; set; }
		/// <summary>
		/// Gets or sets ContentSecurityPolicyViolationType
		/// </summary>
		public ContentSecurityPolicyViolationType ContentSecurityPolicyViolationType { get; set; }
		/// <summary>
		/// Gets or sets FrameAncestor
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedFrame FrameAncestor { get; set; }
		/// <summary>
		/// Gets or sets SourceCodeLocation
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceCodeLocation SourceCodeLocation { get; set; }
		/// <summary>
		/// Gets or sets ViolatingNodeId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ViolatingNodeId { get; set; }
	}
}
