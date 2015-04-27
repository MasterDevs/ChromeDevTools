using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Match data for a CSS rule.
	/// </summary>
	public class RuleMatch
	{
		/// <summary>
		/// Gets or sets CSS rule in the match.
		/// </summary>
		public CSSRule Rule { get; set; }
		/// <summary>
		/// Gets or sets Matching selector indices in the rule's selectorList selectors (0-based).
		/// </summary>
		public long[] MatchingSelectors { get; set; }
	}
}
