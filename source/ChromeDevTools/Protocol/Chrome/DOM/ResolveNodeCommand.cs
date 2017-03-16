using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Resolves JavaScript node object for given node id.
	/// </summary>
	[Command(ProtocolName.DOM.ResolveNode)]
	[SupportedBy("Chrome")]
	public class ResolveNodeCommand
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
