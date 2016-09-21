using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page{
	/// <summary>
	/// Resource type as it was perceived by the rendering engine.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ResourceType
	{
			Document,
			Stylesheet,
			Image,
			Font,
			Script,
			XHR,
			WebSocket,
			Other,
	}
}
