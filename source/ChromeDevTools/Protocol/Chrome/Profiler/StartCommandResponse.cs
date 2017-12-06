using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	[CommandResponse(ProtocolName.Profiler.Start)]
	[SupportedBy("Chrome")]
	public class StartCommandResponse
	{
	}
}
