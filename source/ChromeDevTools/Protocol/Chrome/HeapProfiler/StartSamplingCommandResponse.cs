using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.StartSampling)]
	[SupportedBy("Chrome")]
	public class StartSamplingCommandResponse
	{
	}
}
