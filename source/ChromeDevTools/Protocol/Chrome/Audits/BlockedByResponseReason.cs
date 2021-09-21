using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	/// Enum indicating the reason a response has been blocked. These reasons are
	/// refinements of the net error BLOCKED_BY_RESPONSE.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BlockedByResponseReason
	{
			CoepFrameResourceNeedsCoepHeader,
			CoopSandboxedIFrameCannotNavigateToCoopPage,
			CorpNotSameOrigin,
			CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
			CorpNotSameSite,
	}
}
