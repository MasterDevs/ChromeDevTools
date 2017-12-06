using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Moves node into the new container, places it before the given anchor.
	/// </summary>
	[Command(ProtocolName.DOM.MoveTo)]
	[SupportedBy("iOS")]
	public class MoveToCommand: ICommand<MoveToCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to drop.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Id of the element to drop into.
		/// </summary>
		public long TargetNodeId { get; set; }
		/// <summary>
		/// Gets or sets Drop node before given one.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? InsertBeforeNodeId { get; set; }
	}
}
