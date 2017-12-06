using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Network level fetch failure reason.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ErrorReason
	{
			Failed,
			Aborted,
			TimedOut,
			AccessDenied,
			ConnectionClosed,
			ConnectionReset,
			ConnectionRefused,
			ConnectionAborted,
			ConnectionFailed,
			NameNotResolved,
			InternetDisconnected,
			AddressUnreachable,
	}
}
