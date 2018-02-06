using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Returns the root DOM node to the caller.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetDocument)]
	[SupportedBy("iOS")]
	public class GetDocumentCommandResponse
	{
		/// <summary>
		/// Gets or sets Resulting node.
		/// </summary>
		public Node Root { get; set; }
	}
}
