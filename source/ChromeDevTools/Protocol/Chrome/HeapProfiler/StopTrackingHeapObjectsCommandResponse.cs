using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.StopTrackingHeapObjects)]
	[SupportedBy("Chrome")]
	public class StopTrackingHeapObjectsCommandResponse
	{
	}
}
