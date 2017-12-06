using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Discards search results from the session with the given id. <code>getSearchResults</code> should no longer be called for that search.
	/// </summary>
	[Command(ProtocolName.DOM.DiscardSearchResults)]
	[SupportedBy("iOS")]
	public class DiscardSearchResultsCommand: ICommand<DiscardSearchResultsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Unique search session identifier.
		/// </summary>
		public string SearchId { get; set; }
	}
}
