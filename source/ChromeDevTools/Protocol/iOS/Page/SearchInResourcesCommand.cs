using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Searches for given string in frame / resource tree structure.
	/// </summary>
	[Command(ProtocolName.Page.SearchInResources)]
	[SupportedBy("iOS")]
	public class SearchInResourcesCommand: ICommand<SearchInResourcesCommandResponse>
	{
		/// <summary>
		/// Gets or sets String to search for.
		/// </summary>
		public string Text { get; set; }
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
