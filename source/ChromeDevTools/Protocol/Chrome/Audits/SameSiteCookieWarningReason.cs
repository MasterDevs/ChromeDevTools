using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SameSiteCookieWarningReason
	{
			WarnSameSiteUnspecifiedCrossSiteContext,
			WarnSameSiteNoneInsecure,
			WarnSameSiteUnspecifiedLaxAllowUnsafe,
			WarnSameSiteStrictLaxDowngradeStrict,
			WarnSameSiteStrictCrossDowngradeStrict,
			WarnSameSiteStrictCrossDowngradeLax,
			WarnSameSiteLaxCrossDowngradeStrict,
			WarnSameSiteLaxCrossDowngradeLax,
	}
}
