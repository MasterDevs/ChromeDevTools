using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// This information is currently necessary, as the front-end has a difficult
	/// time finding a specific cookie. With this, we can convey specific error
	/// information without the cookie.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SameSiteCookieIssueDetails
	{
		/// <summary>
		/// Gets or sets If AffectedCookie is not set then rawCookieLine contains the raw
		/// Set-Cookie header string. This hints at a problem where the
		/// cookie line is syntactically or semantically malformed in a way
		/// that no valid cookie could be created.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedCookie Cookie { get; set; }
		/// <summary>
		/// Gets or sets RawCookieLine
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RawCookieLine { get; set; }
		/// <summary>
		/// Gets or sets CookieWarningReasons
		/// </summary>
		public SameSiteCookieWarningReason[] CookieWarningReasons { get; set; }
		/// <summary>
		/// Gets or sets CookieExclusionReasons
		/// </summary>
		public SameSiteCookieExclusionReason[] CookieExclusionReasons { get; set; }
		/// <summary>
		/// Gets or sets Optionally identifies the site-for-cookies and the cookie url, which
		/// may be used by the front-end as additional context.
		/// </summary>
		public SameSiteCookieOperation Operation { get; set; }
		/// <summary>
		/// Gets or sets SiteForCookies
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SiteForCookies { get; set; }
		/// <summary>
		/// Gets or sets CookieUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CookieUrl { get; set; }
		/// <summary>
		/// Gets or sets Request
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedRequest Request { get; set; }
	}
}
