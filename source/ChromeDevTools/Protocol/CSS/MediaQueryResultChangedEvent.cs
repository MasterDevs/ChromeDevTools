using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Fires whenever a MediaQuery result changes (for example, after a browser window has been resized.) The current implementation considers only viewport-dependent media features.
	/// </summary>
	[Event(ProtocolName.CSS.MediaQueryResultChanged)]
	public class MediaQueryResultChangedEvent
	{
	}
}
