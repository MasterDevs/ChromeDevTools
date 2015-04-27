using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Stops sending each frame in the <code>screencastFrame</code>.
	/// </summary>
	[Command(ProtocolName.Page.StopScreencast)]
	public class StopScreencastCommand
	{
	}
}
