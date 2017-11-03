using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Requests that children of the node with given id are returned to the caller in form of <code>setChildNodes</code> events where not only immediate children are retrieved, but all children down to the specified depth.
	/// </summary>
	[Command(ProtocolName.DOM.RequestChildNodes)]
	[SupportedBy("Chrome")]
	public class RequestChildNodesCommand: ICommand<RequestChildNodesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to get children for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Depth { get; set; }
		/// <summary>
		/// Gets or sets Whether or not iframes and shadow roots should be traversed when returning the sub-tree (default is false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Pierce { get; set; }
	}
}
