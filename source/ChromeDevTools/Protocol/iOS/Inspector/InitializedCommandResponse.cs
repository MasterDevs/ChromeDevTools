using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Inspector
{
	/// <summary>
	/// Sent by the frontend after all initialization messages have been sent.
	/// </summary>
	[CommandResponse(ProtocolName.Inspector.Initialized)]
	[SupportedBy("iOS")]
	public class InitializedCommandResponse
	{
	}
}
