using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Removes node with given id.
	/// </summary>
	[Command(ProtocolName.DOM.RemoveNode)]
	public class RemoveNodeCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to remove.
		/// </summary>
		public long NodeId { get; set; }
	}
}
