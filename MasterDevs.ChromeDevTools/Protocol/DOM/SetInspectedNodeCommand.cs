using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
	/// </summary>
	[Command(ProtocolName.DOM.SetInspectedNode)]
	public class SetInspectedNodeCommand
	{
		/// <summary>
		/// Gets or sets DOM node id to be accessible by means of $x command line API.
		/// </summary>
		public long NodeId { get; set; }
	}
}
