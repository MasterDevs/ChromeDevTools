using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Fired when <code>Container</code>'s child node count has changed.
	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeCountUpdated)]
	[SupportedBy("iOS")]
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
