using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns the root DOM node (and optionally the subtree) to the caller.
	/// </summary>
	[Command(ProtocolName.DOM.GetDocument)]
	[SupportedBy("Chrome")]
	public class GetDocumentCommand
	{
		/// <summary>
		/// Gets or sets The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.
		/// </summary>
		public long Depth { get; set; }
		/// <summary>
		/// Gets or sets Whether or not iframes and shadow roots should be traversed when returning the subtree (default is false).
		/// </summary>
		public bool Pierce { get; set; }
	}
}
