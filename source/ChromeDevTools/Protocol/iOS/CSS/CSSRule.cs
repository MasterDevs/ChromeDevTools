using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// CSS rule representation.
	/// </summary>
	[SupportedBy("iOS")]
	public class CSSRule
	{
		/// <summary>
		/// Gets or sets The CSS rule identifier (absent for user agent stylesheet and user-specified stylesheet rules).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSRuleId RuleId { get; set; }
		/// <summary>
		/// Gets or sets Rule selector data.
		/// </summary>
		public SelectorList SelectorList { get; set; }
		/// <summary>
		/// Gets or sets Parent stylesheet resource URL (for regular rules).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets Line ordinal of the rule selector start character in the resource.
		/// </summary>
		public long SourceLine { get; set; }
		/// <summary>
		/// Gets or sets Parent stylesheet's origin.
		/// </summary>
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or sets Associated style declaration.
		/// </summary>
		public CSSStyle Style { get; set; }
		/// <summary>
		/// Gets or sets Media list array (for rules involving media queries). The array enumerates media queries starting with the innermost one, going outwards.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSMedia[] Media { get; set; }
	}
}
