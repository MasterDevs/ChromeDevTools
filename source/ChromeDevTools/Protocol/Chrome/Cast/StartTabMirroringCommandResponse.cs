using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Starts mirroring the tab to the sink.
	/// </summary>
	[CommandResponse(ProtocolName.Cast.StartTabMirroring)]
	[SupportedBy("Chrome")]
	public class StartTabMirroringCommandResponse
	{
	}
}
