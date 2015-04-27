using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>
	[Command(ProtocolName.DOM.GetOuterHTML)]
	public class GetOuterHTMLCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to get markup for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
