using ChromeDevTools;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Mirrors <code>DOMNodeInserted</code> event.
	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeInserted)]
	public class ChildNodeInsertedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
		/// </summary>
		public long ParentNodeId { get; set; }
		/// <summary>
		/// Gets or sets If of the previous siblint.
		/// </summary>
		public long PreviousNodeId { get; set; }
		/// <summary>
		/// Gets or sets Inserted node data.
		/// </summary>
		public Node Node { get; set; }
	}
}
