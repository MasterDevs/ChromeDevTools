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
	[CommandResponse(ProtocolName.DOM.GetQueryingDescendantsForContainer)]
	[SupportedBy("Chrome")]
	public class GetQueryingDescendantsForContainerCommandResponse
	{
		/// <summary>
		/// Gets or sets Descendant nodes with container queries against the given container.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
