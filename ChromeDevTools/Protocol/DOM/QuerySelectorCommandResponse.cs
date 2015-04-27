using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Executes <code>querySelector</code> on a given node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.QuerySelector)]
	public class QuerySelectorCommandResponse
	{
		/// <summary>
		/// Gets or sets Query selector result.
		/// </summary>
		public long NodeId { get; set; }
	}
}
