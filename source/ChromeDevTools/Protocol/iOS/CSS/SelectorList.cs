using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Selector list data.
	/// </summary>
	[SupportedBy("iOS")]
	public class SelectorList
	{
		/// <summary>
		/// Gets or sets Selectors in the list.
		/// </summary>
		public CSSSelector[] Selectors { get; set; }
		/// <summary>
		/// Gets or sets Rule selector text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets Rule selector range in the underlying resource (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
	}
}
