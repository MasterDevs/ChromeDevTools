using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Represents the source scheme of the origin that originally set the cookie.
	/// A value of "Unset" allows protocol clients to emulate legacy cookie scope for the scheme.
	/// This is a temporary ability and it will be removed in the future.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CookieSourceScheme
	{
			Unset,
			NonSecure,
			Secure,
	}
}
