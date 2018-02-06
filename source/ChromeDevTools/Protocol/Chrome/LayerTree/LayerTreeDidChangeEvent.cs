using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	[Event(ProtocolName.LayerTree.LayerTreeDidChange)]
	[SupportedBy("Chrome")]
	public class LayerTreeDidChangeEvent
	{
		/// <summary>
		/// Gets or sets Layer tree, absent if not in the comspositing mode.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Layer[] Layers { get; set; }
	}
}
