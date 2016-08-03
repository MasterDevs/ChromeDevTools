using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Fired when the node should be inspected. This happens after call to <code>setInspectModeEnabled</code>.
	/// </summary>
	[Event(ProtocolName.DOM.InspectNodeRequested)]
	[SupportedBy("Chrome")]
	public class InspectNodeRequestedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node to inspect.
		/// </summary>
		public long BackendNodeId { get; set; }
	}
}
