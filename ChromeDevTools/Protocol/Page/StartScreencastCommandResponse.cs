using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Starts sending each frame using the <code>screencastFrame</code> event.
	/// </summary>
	[CommandResponse(ProtocolName.Page.StartScreencast)]
	public class StartScreencastCommandResponse
	{
	}
}
