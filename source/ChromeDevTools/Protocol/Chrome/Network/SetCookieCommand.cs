using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
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
		/// Gets or sets The request-URI to associate with the setting of the cookie. This value can affect the default domain and path values of the created cookie.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets The name of the cookie.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets The value of the cookie.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets If omitted, the cookie becomes a host-only cookie.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Domain { get; set; }
		/// <summary>
		/// Gets or sets Defaults to the path portion of the url parameter.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Path { get; set; }
		/// <summary>
		/// Gets or sets Defaults ot false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Secure { get; set; }
		/// <summary>
		/// Gets or sets Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HttpOnly { get; set; }
		/// <summary>
		/// Gets or sets Defaults to browser default behavior.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SameSite { get; set; }
		/// <summary>
		/// Gets or sets If omitted, the cookie becomes a session cookie.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ExpirationDate { get; set; }
	}
}
