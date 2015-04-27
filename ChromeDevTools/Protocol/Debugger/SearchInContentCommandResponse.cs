using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Searches for given string in script content.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SearchInContent)]
	public class SearchInContentCommandResponse
	{
		/// <summary>
		/// Gets or sets List of search matches.
		/// </summary>
		public SearchMatch[] Result { get; set; }
	}
}
