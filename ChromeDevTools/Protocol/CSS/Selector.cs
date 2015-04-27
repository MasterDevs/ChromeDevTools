using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Data for a simple selector (these are delimited by commas in a selector list).
	/// </summary>
	public class Selector
	{
		/// <summary>
		/// Gets or sets Selector text.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets Selector range in the underlying resource (if available).
		/// </summary>
		public SourceRange Range { get; set; }
	}
}
