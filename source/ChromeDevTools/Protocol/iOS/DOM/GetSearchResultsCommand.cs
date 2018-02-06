using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Returns search results from given <code>fromIndex</code> to given <code>toIndex</code> from the sarch with the given identifier.
	/// </summary>
	[Command(ProtocolName.DOM.GetSearchResults)]
	[SupportedBy("iOS")]
	public class GetSearchResultsCommand: ICommand<GetSearchResultsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Unique search session identifier.
		/// </summary>
		public string SearchId { get; set; }
		/// <summary>
		/// Gets or sets Start index of the search result to be returned.
		/// </summary>
		public long FromIndex { get; set; }
		/// <summary>
		/// Gets or sets End index of the search result to be returned.
		/// </summary>
		public long ToIndex { get; set; }
	}
}
