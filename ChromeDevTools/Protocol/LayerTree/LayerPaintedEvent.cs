using ChromeDevTools;

namespace ChromeDevTools.Protocol.LayerTree
{
	[Event(ProtocolName.LayerTree.LayerPainted)]
	public class LayerPaintedEvent
	{
		/// <summary>
		/// Gets or sets The id of the painted layer.
		/// </summary>
		public string LayerId { get; set; }
		/// <summary>
		/// Gets or sets Clip rectangle.
		/// </summary>
		public DOM.Rect Clip { get; set; }
	}
}
