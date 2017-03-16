using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when a color has been picked.
	/// </summary>
	[Event(ProtocolName.Page.ColorPicked)]
	[SupportedBy("Chrome")]
	public class ColorPickedEvent
	{
		/// <summary>
		/// Gets or sets RGBA of the picked color.
		/// </summary>
		public DOM.RGBA Color { get; set; }
	}
}
