using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets node name for a node with given id.
	/// </summary>
	[Command(ProtocolName.DOM.SetNodeName)]
	[SupportedBy("Chrome")]
	public class SetNodeNameCommand: ICommand<SetNodeNameCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to set name for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets New node's name.
		/// </summary>
		public string Name { get; set; }
	}
}
