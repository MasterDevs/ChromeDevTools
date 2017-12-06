using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	[Event(ProtocolName.LayerTree.LayerTreeDidChange)]
	[SupportedBy("iOS")]
	public class LayerTreeDidChangeEvent
	{
	}
}
