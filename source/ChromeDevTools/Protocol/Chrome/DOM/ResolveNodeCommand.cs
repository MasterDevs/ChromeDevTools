using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Resolves the JavaScript node object for a given NodeId or BackendNodeId.
	/// </summary>
	[Command(ProtocolName.DOM.ResolveNode)]
	[SupportedBy("Chrome")]
	public class ResolveNodeCommand: ICommand<ResolveNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to resolve.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Gets or sets Backend identifier of the node to resolve.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
	}
}
