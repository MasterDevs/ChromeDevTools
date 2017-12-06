using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Returns search results from given <code>fromIndex</code> to given <code>toIndex</code> from the sarch with the given identifier.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetSearchResults)]
	[SupportedBy("iOS")]
	public class GetSearchResultsCommandResponse
	{
		/// <summary>
		/// Gets or sets Ids of the search result nodes.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
