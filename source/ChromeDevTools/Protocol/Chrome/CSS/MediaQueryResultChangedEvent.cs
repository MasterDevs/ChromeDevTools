using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Fires whenever a MediaQuery result changes (for example, after a browser window has been resized.) The current implementation considers only viewport-dependent media features.
	/// </summary>
	[Event(ProtocolName.CSS.MediaQueryResultChanged)]
	[SupportedBy("Chrome")]
	public class MediaQueryResultChangedEvent
	{
	}
}
