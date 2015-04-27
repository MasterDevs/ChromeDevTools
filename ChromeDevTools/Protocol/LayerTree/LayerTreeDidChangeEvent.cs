using ChromeDevTools;

namespace ChromeDevTools.Protocol.LayerTree
{
	[Event(ProtocolName.LayerTree.LayerTreeDidChange)]
	public class LayerTreeDidChangeEvent
	{
		/// <summary>
		/// Gets or sets Layer tree, absent if not in the comspositing mode.
		/// </summary>
		public Layer[] Layers { get; set; }
	}
}
