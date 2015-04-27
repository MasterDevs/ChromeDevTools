using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.StartTrackingHeapObjects)]
	public class StartTrackingHeapObjectsCommandResponse
	{
	}
}
