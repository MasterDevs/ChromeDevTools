using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.CollectGarbage)]
	[SupportedBy("Chrome")]
	public class CollectGarbageCommand
	{
	}
}
