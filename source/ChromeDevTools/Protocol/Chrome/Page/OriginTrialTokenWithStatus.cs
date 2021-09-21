using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class OriginTrialTokenWithStatus
	{
		/// <summary>
		/// Gets or sets RawTokenText
		/// </summary>
		public string RawTokenText { get; set; }
		/// <summary>
		/// Gets or sets `parsedToken` is present only when the token is extractable and
		/// parsable.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public OriginTrialToken ParsedToken { get; set; }
		/// <summary>
		/// Gets or sets Status
		/// </summary>
		public OriginTrialTokenStatus Status { get; set; }
	}
}
