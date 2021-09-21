using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// A cookie with was not sent with a request with the corresponding reason.
	/// </summary>
	[SupportedBy("Chrome")]
	public class BlockedCookieWithReason
	{
		/// <summary>
		/// Gets or sets The reason(s) the cookie was blocked.
		/// </summary>
		public CookieBlockedReason[] BlockedReasons { get; set; }
		/// <summary>
		/// Gets or sets The cookie object representing the cookie which was not sent.
		/// </summary>
		public Cookie Cookie { get; set; }
	}
}
