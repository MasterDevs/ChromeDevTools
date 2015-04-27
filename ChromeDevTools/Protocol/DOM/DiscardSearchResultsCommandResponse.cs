using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Discards search results from the session with the given id. <code>getSearchResults</code> should no longer be called for that search.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.DiscardSearchResults)]
	public class DiscardSearchResultsCommandResponse
	{
	}
}
