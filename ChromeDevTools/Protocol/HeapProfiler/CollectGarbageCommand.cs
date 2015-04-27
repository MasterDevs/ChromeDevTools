using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.CollectGarbage)]
	public class CollectGarbageCommand
	{
	}
}
