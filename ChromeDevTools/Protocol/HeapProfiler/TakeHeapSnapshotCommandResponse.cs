using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.TakeHeapSnapshot)]
	public class TakeHeapSnapshotCommandResponse
	{
	}
}
