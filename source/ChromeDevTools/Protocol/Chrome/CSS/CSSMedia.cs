using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS media rule descriptor.
	/// </summary>
	[SupportedBy("Chrome")]
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
		/// Gets or sets The associated rule (@media or @import) header range in the enclosing stylesheet (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the stylesheet containing this object (if exists).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Array of media queries.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public MediaQuery[] MediaList { get; set; }
	}
}
