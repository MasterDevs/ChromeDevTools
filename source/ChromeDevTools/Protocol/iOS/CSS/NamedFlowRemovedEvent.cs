using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Fires when a Named Flow is removed: has no associated content nodes and regions.
	/// </summary>
	[Event(ProtocolName.CSS.NamedFlowRemoved)]
	[SupportedBy("iOS")]
	public class NamedFlowRemovedEvent
	{
		/// <summary>
		/// Gets or sets The document node id.
		/// </summary>
		public long DocumentNodeId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the removed Named Flow.
		/// </summary>
		public string FlowName { get; set; }
	}
}
