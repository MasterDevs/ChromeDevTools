using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Represents the cookie's 'SameSite' status: https://tools.ietf.org/html/draft-west-first-party-cookies
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CookieSameSite
	{
			Strict,
			Lax,
	}
}
