using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// The underlying connection technology that the browser is supposedly using.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConnectionType
	{
			None,
			Cellular2g,
			Cellular3g,
			Cellular4g,
			Bluetooth,
			Ethernet,
			Wifi,
			Wimax,
			Other,
	}
}
