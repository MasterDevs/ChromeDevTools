using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Search match for resource.
	/// </summary>
	public class SearchMatch
	{
		/// <summary>
		/// Gets or sets Line number in resource content.
		/// </summary>
		public double LineNumber { get; set; }
		/// <summary>
		/// Gets or sets Line with match content.
		/// </summary>
		public string LineContent { get; set; }
	}
}
