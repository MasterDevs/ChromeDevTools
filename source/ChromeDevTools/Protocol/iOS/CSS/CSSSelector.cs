using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// CSS selector.
	/// </summary>
	[SupportedBy("iOS")]
	public class CSSSelector
	{
		/// <summary>
		/// Gets or sets Canonicalized selector text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets Specificity (a, b, c) tuple. Included if the selector is sent in response to CSS.getMatchedStylesForNode which provides a context element.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long[] Specificity { get; set; }
		/// <summary>
		/// Gets or sets Whether or not the specificity can be dynamic. Included if the selector is sent in response to CSS.getMatchedStylesForNode which provides a context element.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Dynamic { get; set; }
	}
}
