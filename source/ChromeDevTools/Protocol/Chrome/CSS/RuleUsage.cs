using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS coverage information.
	/// </summary>
	[SupportedBy("Chrome")]
	public class RuleUsage
	{
		/// <summary>
		/// Gets or sets The css style sheet identifier (absent for user agent stylesheet and user-specified stylesheet rules) this rule came from.
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Offset of the start of the rule (including selector) from the beginning of the stylesheet.
		/// </summary>
		public double StartOffset { get; set; }
		/// <summary>
		/// Gets or sets Offset of the end of the rule body from the beginning of the stylesheet.
		/// </summary>
		public double EndOffset { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether the rule was actually used by some element in the page.
		/// </summary>
		public bool Used { get; set; }
	}
}
