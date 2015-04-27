using ChromeDevTools;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Fired whenever a stylesheet is changed as a result of the client operation.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetChanged)]
	public class StyleSheetChangedEvent
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
