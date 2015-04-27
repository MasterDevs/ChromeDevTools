using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Moves node into the new container, places it before the given anchor.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.MoveTo)]
	public class MoveToCommandResponse
	{
		/// <summary>
		/// Gets or sets New id of the moved node.
		/// </summary>
		public long NodeId { get; set; }
	}
}
