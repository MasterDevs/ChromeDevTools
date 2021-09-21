using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Stops sending each frame in the `screencastFrame`.
	/// </summary>
	[Command(ProtocolName.Page.StopScreencast)]
	[SupportedBy("Chrome")]
	public class StopScreencastCommand: ICommand<StopScreencastCommandResponse>
	{
	}
}
