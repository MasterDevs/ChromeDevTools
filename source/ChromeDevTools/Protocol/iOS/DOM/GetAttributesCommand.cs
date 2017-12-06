using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Returns attributes for the specified node.
	/// </summary>
	[Command(ProtocolName.DOM.GetAttributes)]
	[SupportedBy("iOS")]
	public class GetAttributesCommand: ICommand<GetAttributesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to retrieve attibutes for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
