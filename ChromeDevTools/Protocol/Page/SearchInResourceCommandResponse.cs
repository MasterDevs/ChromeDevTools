using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Searches for given string in resource content.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SearchInResource)]
	public class SearchInResourceCommandResponse
	{
		/// <summary>
		/// Gets or sets List of search matches.
		/// </summary>
		public Debugger.SearchMatch[] Result { get; set; }
	}
}
