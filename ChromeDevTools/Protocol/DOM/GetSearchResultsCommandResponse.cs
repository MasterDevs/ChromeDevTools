using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns search results from given <code>fromIndex</code> to given <code>toIndex</code> from the sarch with the given identifier.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetSearchResults)]
	public class GetSearchResultsCommandResponse
	{
		/// <summary>
		/// Gets or sets Ids of the search result nodes.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
