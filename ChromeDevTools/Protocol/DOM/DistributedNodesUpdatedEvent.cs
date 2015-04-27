using ChromeDevTools;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Called when distrubution is changed.
	/// </summary>
	[Event(ProtocolName.DOM.DistributedNodesUpdated)]
	public class DistributedNodesUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Insertion point where distrubuted nodes were updated.
		/// </summary>
		public long InsertionPointId { get; set; }
		/// <summary>
		/// Gets or sets Distributed nodes for given insertion point.
		/// </summary>
		public BackendNode[] DistributedNodes { get; set; }
	}
}
