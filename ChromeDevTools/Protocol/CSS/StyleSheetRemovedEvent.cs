using ChromeDevTools;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is removed.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetRemoved)]
	public class StyleSheetRemovedEvent
	{
		/// <summary>
		/// Gets or sets Identifier of the removed stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
