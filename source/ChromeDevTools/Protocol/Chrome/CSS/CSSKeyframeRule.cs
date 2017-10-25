using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS keyframe rule representation.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSKeyframeRule
	{
		/// <summary>
		/// Gets or sets The css style sheet identifier (absent for user agent stylesheet and user-specified stylesheet rules) this rule came from.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Parent stylesheet's origin.
		/// </summary>
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or sets Associated key text.
		/// </summary>
		public Value KeyText { get; set; }
		/// <summary>
		/// Gets or sets Associated style declaration.
		/// </summary>
		public CSSStyle Style { get; set; }
	}
}
