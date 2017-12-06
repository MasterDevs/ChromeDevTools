using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Discards search results from the session with the given id. <code>getSearchResults</code> should no longer be called for that search.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.DiscardSearchResults)]
	[SupportedBy("Chrome")]
	public class DiscardSearchResultsCommandResponse
	{
	}
}
