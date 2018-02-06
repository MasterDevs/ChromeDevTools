using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Starts sending each frame using the <code>screencastFrame</code> event.
	/// </summary>
	[CommandResponse(ProtocolName.Page.StartScreencast)]
	[SupportedBy("Chrome")]
	public class StartScreencastCommandResponse
	{
	}
}
