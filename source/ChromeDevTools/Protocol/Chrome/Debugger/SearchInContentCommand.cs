using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Searches for given string in script content.
	/// </summary>
	[Command(ProtocolName.Debugger.SearchInContent)]
	[SupportedBy("Chrome")]
	public class SearchInContentCommand: ICommand<SearchInContentCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the script to search in.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets String to search for.
		/// </summary>
		public string Query { get; set; }
		/// <summary>
		/// Gets or sets If true, search is case sensitive.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? CaseSensitive { get; set; }
		/// <summary>
		/// Gets or sets If true, treats string parameter as regex.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsRegex { get; set; }
	}
}
