using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Searches for given string in script content.
	/// </summary>
	[Command(ProtocolName.Debugger.SearchInContent)]
	public class SearchInContentCommand
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
		public bool CaseSensitive { get; set; }
		/// <summary>
		/// Gets or sets If true, treats string parameter as regex.
		/// </summary>
		public bool IsRegex { get; set; }
	}
}
