using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Returns event listeners relevant to the node.
	/// </summary>
	[Command(ProtocolName.DOM.GetEventListenersForNode)]
	[SupportedBy("iOS")]
	public class GetEventListenersForNodeCommand: ICommand<GetEventListenersForNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to get listeners for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name for handler value. Handler value is not returned without this parameter specified.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
	}
}
