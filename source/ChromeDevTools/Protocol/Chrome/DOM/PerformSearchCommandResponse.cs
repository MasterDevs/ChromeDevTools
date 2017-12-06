using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Searches for a given string in the DOM tree. Use <code>getSearchResults</code> to access search results or <code>cancelSearch</code> to end this search session.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.PerformSearch)]
	[SupportedBy("Chrome")]
	public class PerformSearchCommandResponse
	{
		/// <summary>
		/// Gets or sets Unique search session identifier.
		/// </summary>
		public string SearchId { get; set; }
		/// <summary>
		/// Gets or sets Number of search results.
		/// </summary>
		public long ResultCount { get; set; }
	}
}
