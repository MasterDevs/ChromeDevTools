using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Query a DOM node's accessibility subtree for accessible name and role.
	/// This command computes the name and role for all nodes in the subtree, including those that are
	/// ignored for accessibility, and returns those that mactch the specified name and role. If no DOM
	/// node is specified, or the DOM node does not exist, the command returns an error. If neither
	/// `accessibleName` or `role` is specified, it returns all the accessibility nodes in the subtree.
	/// </summary>
	[Command(ProtocolName.Accessibility.QueryAXTree)]
	[SupportedBy("Chrome")]
	public class QueryAXTreeCommand: ICommand<QueryAXTreeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the node for the root to query.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the backend node for the root to query.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets JavaScript object id of the node wrapper for the root to query.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Find nodes with this computed name.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string AccessibleName { get; set; }
		/// <summary>
		/// Gets or sets Find nodes with this computed role.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Role { get; set; }
	}
}
