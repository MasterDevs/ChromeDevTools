using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Stops sending each frame in the <code>screencastFrame</code>.
	/// </summary>
	[CommandResponse(ProtocolName.Page.StopScreencast)]
	[SupportedBy("Chrome")]
	public class StopScreencastCommandResponse
	{
	}
}
