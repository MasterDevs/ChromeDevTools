using ChromeDevTools;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Fired when <code>Container</code>'s child node count has changed.
	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeCountUpdated)]
	public class ChildNodeCountUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets New node count.
		/// </summary>
		public long ChildNodeCount { get; set; }
	}
}
