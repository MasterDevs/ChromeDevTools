using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Searches for a given string in the DOM tree. Use <code>getSearchResults</code> to access search results or <code>cancelSearch</code> to end this search session.
	/// </summary>
	[Command(ProtocolName.DOM.PerformSearch)]
	[SupportedBy("iOS")]
	public class PerformSearchCommand: ICommand<PerformSearchCommandResponse>
	{
		/// <summary>
		/// Gets or sets Plain text or query selector or XPath search query.
		/// </summary>
		public string Query { get; set; }
		/// <summary>
		/// Gets or sets Ids of nodes to use as starting points for the search.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] NodeIds { get; set; }
	}
}
