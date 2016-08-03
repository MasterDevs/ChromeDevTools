using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Called when a pseudo element is removed from an element.
	/// </summary>
	[Event(ProtocolName.DOM.PseudoElementRemoved)]
	[SupportedBy("iOS")]
	public class PseudoElementRemovedEvent
	{
		/// <summary>
		/// Gets or sets Pseudo element's parent element id.
		/// </summary>
		public long ParentId { get; set; }
		/// <summary>
		/// Gets or sets The removed pseudo element id.
		/// </summary>
		public long PseudoElementId { get; set; }
	}
}
