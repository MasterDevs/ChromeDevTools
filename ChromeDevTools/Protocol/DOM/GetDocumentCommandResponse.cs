using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns the root DOM node to the caller.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetDocument)]
	public class GetDocumentCommandResponse
	{
		/// <summary>
		/// Gets or sets Resulting node.
		/// </summary>
		public Node Root { get; set; }
	}
}
