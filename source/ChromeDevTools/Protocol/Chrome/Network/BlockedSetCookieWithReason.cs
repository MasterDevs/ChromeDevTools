using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// A cookie which was not stored from a response with the corresponding reason.
	/// </summary>
	[SupportedBy("Chrome")]
	public class BlockedSetCookieWithReason
	{
		/// <summary>
		/// Gets or sets The reason(s) this cookie was blocked.
		/// </summary>
		public SetCookieBlockedReason[] BlockedReasons { get; set; }
		/// <summary>
		/// Gets or sets The string representing this individual cookie as it would appear in the header.
	/// This is not the entire "cookie" or "set-cookie" header which could have multiple cookies.
		/// </summary>
		public string CookieLine { get; set; }
		/// <summary>
		/// Gets or sets The cookie object which represents the cookie which was not stored. It is optional because
		/// sometimes complete cookie information is not available, such as in the case of parsing
		/// errors.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Cookie Cookie { get; set; }
	}
}
