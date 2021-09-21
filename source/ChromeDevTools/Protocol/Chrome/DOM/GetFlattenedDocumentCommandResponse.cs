using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns the root DOM node (and optionally the subtree) to the caller.
	/// Deprecated, as it is not designed to work well with the rest of the DOM agent.
	/// Use DOMSnapshot.captureSnapshot instead.
	/// </summary>
	[Obsolete]
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
