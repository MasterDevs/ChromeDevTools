using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// CSS media query descriptor.
	/// </summary>
	[SupportedBy("iOS")]
	public class CSSMedia
	{
		/// <summary>
		/// Gets or sets Media query text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets Source of the media query: "mediaRule" if specified by a @media rule, "importRule" if specified by an @import rule, "linkedSheet" if specified by a "media" attribute in a linked stylesheet's LINK tag, "inlineSheet" if specified by a "media" attribute in an inline stylesheet's STYLE tag.
		/// </summary>
		public string Source { get; set; }
		/// <summary>
		/// Gets or sets URL of the document containing the media query description.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets Line in the document containing the media query (not defined for the "stylesheet" source).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? SourceLine { get; set; }
	}
}
