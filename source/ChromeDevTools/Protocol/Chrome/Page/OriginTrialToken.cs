using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class OriginTrialToken
	{
		/// <summary>
		/// Gets or sets Origin
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets MatchSubDomains
		/// </summary>
		public bool MatchSubDomains { get; set; }
		/// <summary>
		/// Gets or sets TrialName
		/// </summary>
		public string TrialName { get; set; }
		/// <summary>
		/// Gets or sets ExpiryTime
		/// </summary>
		public double ExpiryTime { get; set; }
		/// <summary>
		/// Gets or sets IsThirdParty
		/// </summary>
		public bool IsThirdParty { get; set; }
		/// <summary>
		/// Gets or sets UsageRestriction
		/// </summary>
		public OriginTrialUsageRestriction UsageRestriction { get; set; }
	}
}
