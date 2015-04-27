using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Creates a deep copy of the specified node and places it into the target container before the given anchor.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.CopyTo)]
	public class CopyToCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the node clone.
		/// </summary>
		public long NodeId { get; set; }
	}
}
