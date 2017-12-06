using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Called when shadow root is pushed into the element.
	/// </summary>
	[Event(ProtocolName.DOM.ShadowRootPushed)]
	[SupportedBy("Chrome")]
	public class ShadowRootPushedEvent
	{
		/// <summary>
		/// Gets or sets Host element id.
		/// </summary>
		public long HostId { get; set; }
		/// <summary>
		/// Gets or sets Shadow root.
		/// </summary>
		public Node Root { get; set; }
	}
}
