using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// CSS property declaration data.
	/// </summary>
	public class CSSProperty
	{
		/// <summary>
		/// Gets or sets The property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets The property value.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets Whether the property has "!important" annotation (implies <code>false</code> if absent).
		/// </summary>
		public bool Important { get; set; }
		/// <summary>
		/// Gets or sets Whether the property is implicit (implies <code>false</code> if absent).
		/// </summary>
		public bool Implicit { get; set; }
		/// <summary>
		/// Gets or sets The full property text as specified in the style.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets Whether the property is understood by the browser (implies <code>true</code> if absent).
		/// </summary>
		public bool ParsedOk { get; set; }
		/// <summary>
		/// Gets or sets Whether the property is disabled by the user (present for source-based properties only).
		/// </summary>
		public bool Disabled { get; set; }
		/// <summary>
		/// Gets or sets The entire property range in the enclosing style declaration (if available).
		/// </summary>
		public SourceRange Range { get; set; }
	}
}
