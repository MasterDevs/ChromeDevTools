using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[Event(ProtocolName.Page.FrameResized)]
	[SupportedBy("Chrome")]
	public class FrameResizedEvent
	{
	}
}
