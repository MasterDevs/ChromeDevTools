using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// CSS style representation.
	/// </summary>
	[SupportedBy("iOS")]
	public class CSSStyle
	{
		/// <summary>
		/// Gets or sets The CSS style identifier (absent for attribute styles).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSStyleId StyleId { get; set; }
		/// <summary>
		/// Gets or sets CSS properties in the style.
		/// </summary>
		public CSSProperty[] CssProperties { get; set; }
		/// <summary>
		/// Gets or sets Computed values for all shorthands found in the style.
		/// </summary>
		public ShorthandEntry[] ShorthandEntries { get; set; }
		/// <summary>
		/// Gets or sets Style declaration text (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CssText { get; set; }
		/// <summary>
		/// Gets or sets Style declaration range in the enclosing stylesheet (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets The effective "width" property value from this style.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Width { get; set; }
		/// <summary>
		/// Gets or sets The effective "height" property value from this style.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Height { get; set; }
	}
}
