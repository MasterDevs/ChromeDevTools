using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Finds nodes with a given computed style in a subtree.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetNodesForSubtreeByStyle)]
	[SupportedBy("Chrome")]
	public class GetNodesForSubtreeByStyleCommandResponse
	{
		/// <summary>
		/// Gets or sets Resulting nodes.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
