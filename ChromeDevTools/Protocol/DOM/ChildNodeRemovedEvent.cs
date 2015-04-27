using ChromeDevTools;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Mirrors <code>DOMNodeRemoved</code> event.
	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeRemoved)]
	public class ChildNodeRemovedEvent
	{
		/// <summary>
		/// Gets or sets Parent id.
		/// </summary>
		public long ParentNodeId { get; set; }
		/// <summary>
		/// Gets or sets Id of the node that has been removed.
		/// </summary>
		public long NodeId { get; set; }
	}
}
