using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Stops the active Cast session on the sink.
	/// </summary>
	[CommandResponse(ProtocolName.Cast.StopCasting)]
	[SupportedBy("Chrome")]
	public class StopCastingCommandResponse
	{
	}
}
