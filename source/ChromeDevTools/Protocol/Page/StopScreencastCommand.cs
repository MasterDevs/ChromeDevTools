using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Stops sending each frame in the <code>screencastFrame</code>.
	/// </summary>
	[Command(ProtocolName.Page.StopScreencast)]
	public class StopScreencastCommand
	{
	}
}
