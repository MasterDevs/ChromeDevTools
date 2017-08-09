using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	[Event(ProtocolName.DOM.NodeHighlightRequested)]
	[SupportedBy("Chrome")]
	public class NodeHighlightRequestedEvent
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
