using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Event(ProtocolName.HeapProfiler.ResetProfiles)]
	[SupportedBy("Chrome")]
	public class ResetProfilesEvent
	{
	}
}
