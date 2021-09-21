using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// An inspector issue reported from the back-end.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InspectorIssue
	{
		/// <summary>
		/// Gets or sets Code
		/// </summary>
		public InspectorIssueCode Code { get; set; }
		/// <summary>
		/// Gets or sets Details
		/// </summary>
		public InspectorIssueDetails Details { get; set; }
		/// <summary>
		/// Gets or sets A unique id for this issue. May be omitted if no other entity (e.g.
		/// exception, CDP message, etc.) is referencing this issue.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string IssueId { get; set; }
	}
}
