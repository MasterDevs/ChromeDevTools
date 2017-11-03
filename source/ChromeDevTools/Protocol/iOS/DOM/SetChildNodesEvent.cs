using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Fired when backend wants to provide client with the missing DOM structure. This happens upon most of the calls requesting node ids.
	/// </summary>
	[Event(ProtocolName.DOM.SetChildNodes)]
	[SupportedBy("iOS")]
	public class SetChildNodesEvent
	{
		/// <summary>
		/// Gets or sets Parent node id to populate with children.
		/// </summary>
		public long ParentId { get; set; }
		/// <summary>
		/// Gets or sets Child nodes array.
		/// </summary>
		public Node[] Nodes { get; set; }
	}
}
