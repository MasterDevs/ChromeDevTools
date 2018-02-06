using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
	/// </summary>
	[Command(ProtocolName.DOM.SetInspectedNode)]
	[SupportedBy("Chrome")]
	public class SetInspectedNodeCommand: ICommand<SetInspectedNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets DOM node id to be accessible by means of $x command line API.
		/// </summary>
		public long NodeId { get; set; }
	}
}
