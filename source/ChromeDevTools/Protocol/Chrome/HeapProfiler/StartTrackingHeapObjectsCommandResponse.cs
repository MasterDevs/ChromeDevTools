using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.StartTrackingHeapObjects)]
	[SupportedBy("Chrome")]
	public class StartTrackingHeapObjectsCommandResponse
	{
	}
}
