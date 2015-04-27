using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns event listeners relevant to the node.
	/// </summary>
	[Command(ProtocolName.DOM.GetEventListenersForNode)]
	public class GetEventListenersForNodeCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to get listeners for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name for handler value. Handler value is not returned without this parameter specified.
		/// </summary>
		public string ObjectGroup { get; set; }
	}
}
