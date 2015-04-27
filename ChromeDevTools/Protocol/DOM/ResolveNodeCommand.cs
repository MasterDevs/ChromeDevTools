using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Resolves JavaScript node object for given node id.
	/// </summary>
	[Command(ProtocolName.DOM.ResolveNode)]
	public class ResolveNodeCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to resolve.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		public string ObjectGroup { get; set; }
	}
}
