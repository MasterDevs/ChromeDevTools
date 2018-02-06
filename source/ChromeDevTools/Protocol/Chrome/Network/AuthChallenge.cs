using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Authorization challenge for HTTP status code 401 or 407.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AuthChallenge
	{
		/// <summary>
		/// Gets or sets Source of the authentication challenge.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Source { get; set; }
		/// <summary>
		/// Gets or sets Origin of the challenger.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets The authentication scheme used, such as basic or digest
		/// </summary>
		public string Scheme { get; set; }
		/// <summary>
		/// Gets or sets The realm of the challenge. May be empty.
		/// </summary>
		public string Realm { get; set; }
	}
}
