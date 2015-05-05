using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Discards search results from the session with the given id. <code>getSearchResults</code> should no longer be called for that search.
	/// </summary>
	[Command(ProtocolName.DOM.DiscardSearchResults)]
	public class DiscardSearchResultsCommand
	{
		/// <summary>
		/// Gets or sets Unique search session identifier.
		/// </summary>
		public string SearchId { get; set; }
	}
}
