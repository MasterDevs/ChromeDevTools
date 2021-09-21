using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Searches for given string in response content.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SearchInResponseBody)]
	[SupportedBy("Chrome")]
	public class SearchInResponseBodyCommandResponse
	{
		/// <summary>
		/// Gets or sets List of search matches.
		/// </summary>
		public Debugger.SearchMatch[] Result { get; set; }
	}
}
