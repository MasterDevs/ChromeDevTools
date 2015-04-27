using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Executes <code>querySelectorAll</code> on a given node.
	/// </summary>
	[Command(ProtocolName.DOM.QuerySelectorAll)]
	public class QuerySelectorAllCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to query upon.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Selector string.
		/// </summary>
		public string Selector { get; set; }
	}
}
