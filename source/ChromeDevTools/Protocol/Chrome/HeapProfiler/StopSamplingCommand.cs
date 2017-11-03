using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.StopSampling)]
	[SupportedBy("Chrome")]
	public class StopSamplingCommand: ICommand<StopSamplingCommandResponse>
	{
	}
}
