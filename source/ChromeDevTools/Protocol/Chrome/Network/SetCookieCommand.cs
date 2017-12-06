using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
	/// </summary>
	[Command(ProtocolName.Network.SetCookie)]
	[SupportedBy("Chrome")]
	public class SetCookieCommand: ICommand<SetCookieCommandResponse>
	{
		/// <summary>
		/// Gets or sets Cookie name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Cookie value.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets The request-URI to associate with the setting of the cookie. This value can affect the default domain and path values of the created cookie.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Cookie domain.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Domain { get; set; }
		/// <summary>
		/// Gets or sets Cookie path.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Path { get; set; }
		/// <summary>
		/// Gets or sets True if cookie is secure.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Secure { get; set; }
		/// <summary>
		/// Gets or sets True if cookie is http-only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HttpOnly { get; set; }
		/// <summary>
		/// Gets or sets Cookie SameSite type.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SameSite { get; set; }
		/// <summary>
		/// Gets or sets Cookie expiration date, session cookie if not set
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Expires { get; set; }
	}
}
