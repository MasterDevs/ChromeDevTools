using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Fired when the node should be inspected. This happens after call to <code>setInspectMode</code> or when user manually inspects an element.
	/// </summary>
	[Event(ProtocolName.Overlay.InspectNodeRequested)]
	[SupportedBy("Chrome")]
	public class InspectNodeRequestedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node to inspect.
		/// </summary>
		public long BackendNodeId { get; set; }
	}
}
