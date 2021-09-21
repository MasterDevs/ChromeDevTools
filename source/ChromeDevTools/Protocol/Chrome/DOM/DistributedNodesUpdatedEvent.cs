using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Called when distribution is changed.
	/// </summary>
	[Event(ProtocolName.DOM.DistributedNodesUpdated)]
	[SupportedBy("Chrome")]
	public class DistributedNodesUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Insertion point where distributed nodes were updated.
		/// </summary>
		public long InsertionPointId { get; set; }
		/// <summary>
		/// Gets or sets Distributed nodes for given insertion point.
		/// </summary>
		public BackendNode[] DistributedNodes { get; set; }
	}
}
