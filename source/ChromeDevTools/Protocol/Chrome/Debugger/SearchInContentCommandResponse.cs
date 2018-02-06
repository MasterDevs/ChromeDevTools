using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Searches for given string in script content.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SearchInContent)]
	[SupportedBy("Chrome")]
	public class SearchInContentCommandResponse
	{
		/// <summary>
		/// Gets or sets List of search matches.
		/// </summary>
		public SearchMatch[] Result { get; set; }
	}
}
