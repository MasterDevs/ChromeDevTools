using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Whether the request complied with Certificate Transparency policy.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CertificateTransparencyCompliance
	{
			Unknown,
			[EnumMember(Value = "not-compliant")]
			Not_compliant,
			Compliant,
	}
}
