using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Moves node into the new container, places it before the given anchor.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.MoveTo)]
	[SupportedBy("Chrome")]
	public class MoveToCommandResponse
	{
		/// <summary>
		/// Gets or sets New id of the moved node.
		/// </summary>
		public long NodeId { get; set; }
	}
}
