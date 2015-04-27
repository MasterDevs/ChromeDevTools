using ChromeDevTools;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is added.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetAdded)]
	public class StyleSheetAddedEvent
	{
		/// <summary>
		/// Gets or sets Added stylesheet metainfo.
		/// </summary>
		public CSSStyleSheetHeader Header { get; set; }
	}
}
