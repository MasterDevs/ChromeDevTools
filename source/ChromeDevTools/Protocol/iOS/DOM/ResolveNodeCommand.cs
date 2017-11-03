using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Resolves JavaScript node object for given node id.
	/// </summary>
	[Command(ProtocolName.DOM.ResolveNode)]
	[SupportedBy("iOS")]
	public class ResolveNodeCommand: ICommand<ResolveNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to resolve.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
	}
}
