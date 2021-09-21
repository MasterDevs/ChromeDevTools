using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns the descendants of a container query container that have
	/// container queries against this container.
	/// </summary>
	[Command(ProtocolName.DOM.GetQueryingDescendantsForContainer)]
	[SupportedBy("Chrome")]
	public class GetQueryingDescendantsForContainerCommand: ICommand<GetQueryingDescendantsForContainerCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the container node to find querying descendants from.
		/// </summary>
		public long NodeId { get; set; }
	}
}
