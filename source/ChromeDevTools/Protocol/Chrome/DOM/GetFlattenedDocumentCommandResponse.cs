using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns the root DOM node (and optionally the subtree) to the caller.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetFlattenedDocument)]
	[SupportedBy("Chrome")]
	public class GetFlattenedDocumentCommandResponse
	{
		/// <summary>
		/// Gets or sets Resulting node.
		/// </summary>
		public Node[] Nodes { get; set; }
	}
}
