using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.CollectGarbage)]
	[SupportedBy("Chrome")]
	public class CollectGarbageCommandResponse
	{
	}
}
