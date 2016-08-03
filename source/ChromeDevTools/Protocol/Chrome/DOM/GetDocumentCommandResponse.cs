using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns the root DOM node to the caller.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetDocument)]
	[SupportedBy("Chrome")]
	public class GetDocumentCommandResponse
	{
		/// <summary>
		/// Gets or sets Resulting node.
		/// </summary>
		public Node Root { get; set; }
	}
}
