using ChromeDevTools;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Called when a pseudo element is added to an element.
	/// </summary>
	[Event(ProtocolName.DOM.PseudoElementAdded)]
	public class PseudoElementAddedEvent
	{
		/// <summary>
		/// Gets or sets Pseudo element's parent element id.
		/// </summary>
		public long ParentId { get; set; }
		/// <summary>
		/// Gets or sets The added pseudo element.
		/// </summary>
		public Node PseudoElement { get; set; }
	}
}
