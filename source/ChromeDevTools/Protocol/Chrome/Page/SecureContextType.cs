using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Indicates whether the frame is a secure context and why it is the case.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SecureContextType
	{
			Secure,
			SecureLocalhost,
			InsecureScheme,
			InsecureAncestor,
	}
}
