using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets node value for a node with given id.
	/// </summary>
	[Command(ProtocolName.DOM.SetNodeValue)]
	[SupportedBy("Chrome")]
	public class SetNodeValueCommand: ICommand<SetNodeValueCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to set value for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets New node's value.
		/// </summary>
		public string Value { get; set; }
	}
}
