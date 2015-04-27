using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// CSS rule representation.
	/// </summary>
	public class CSSRule
	{
		/// <summary>
		/// Gets or sets The css style sheet identifier (absent for user agent stylesheet and user-specified stylesheet rules) this rule came from.
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Rule selector data.
		/// </summary>
		public SelectorList SelectorList { get; set; }
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
		public CSSMedia[] Media { get; set; }
	}
}
