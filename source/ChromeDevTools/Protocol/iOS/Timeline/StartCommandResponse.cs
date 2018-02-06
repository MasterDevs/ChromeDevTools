using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	/// Starts capturing instrumentation events.
	/// </summary>
	[CommandResponse(ProtocolName.Timeline.Start)]
	[SupportedBy("iOS")]
	public class StartCommandResponse
	{
	}
}
