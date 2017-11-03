using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets node name for a node with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetNodeName)]
	[SupportedBy("Chrome")]
	public class SetNodeNameCommandResponse
	{
		/// <summary>
		/// Gets or sets New node's id.
		/// </summary>
		public long NodeId { get; set; }
	}
}
