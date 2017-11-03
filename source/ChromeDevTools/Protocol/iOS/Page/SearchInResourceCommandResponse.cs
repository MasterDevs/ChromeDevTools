using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Searches for given string in resource content.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SearchInResource)]
	[SupportedBy("iOS")]
	public class SearchInResourceCommandResponse
	{
		/// <summary>
		/// Gets or sets List of search matches.
		/// </summary>
		public GenericTypes.SearchMatch[] Result { get; set; }
	}
}
