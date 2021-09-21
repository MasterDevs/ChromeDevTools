using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
	/// </summary>
	[Command(ProtocolName.Accessibility.GetPartialAXTree)]
	[SupportedBy("Chrome")]
	public class GetPartialAXTreeCommand: ICommand<GetPartialAXTreeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the node to get the partial accessibility tree for.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the backend node to get the partial accessibility tree for.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets JavaScript object id of the node wrapper to get the partial accessibility tree for.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Whether to fetch this nodes ancestors, siblings and children. Defaults to true.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? FetchRelatives { get; set; }
	}
}
