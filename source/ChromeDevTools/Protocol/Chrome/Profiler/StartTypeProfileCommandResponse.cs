using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Enable type profile.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.StartTypeProfile)]
	[SupportedBy("Chrome")]
	public class StartTypeProfileCommandResponse
	{
	}
}
