using ChromeDevTools;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when a color has been picked.
	/// </summary>
	[Event(ProtocolName.Page.ColorPicked)]
	public class ColorPickedEvent
	{
		/// <summary>
		/// Gets or sets RGBA of the picked color.
		/// </summary>
		public DOM.RGBA Color { get; set; }
	}
}
