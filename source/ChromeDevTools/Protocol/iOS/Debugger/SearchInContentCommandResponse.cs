using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Searches for given string in script content.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SearchInContent)]
	[SupportedBy("iOS")]
	public class SearchInContentCommandResponse
	{
		/// <summary>
		/// Gets or sets List of search matches.
		/// </summary>
		public GenericTypes.SearchMatch[] Result { get; set; }
	}
}
