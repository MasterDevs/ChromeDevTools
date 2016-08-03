using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page{
	/// <summary>
	/// Resource type as it was perceived by the rendering engine.
	/// </summary>
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
