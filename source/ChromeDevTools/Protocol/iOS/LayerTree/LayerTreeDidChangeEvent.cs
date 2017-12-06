using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	[Event(ProtocolName.LayerTree.LayerTreeDidChange)]
	[SupportedBy("iOS")]
	public class LayerTreeDidChangeEvent
	{
	}
}
