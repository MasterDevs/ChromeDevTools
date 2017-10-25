using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS stylesheet metainformation.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSStyleSheetHeader
	{
		/// <summary>
		/// Gets or sets The stylesheet identifier.
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Owner frame identifier.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Stylesheet resource URL.
		/// </summary>
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets URL of source map associated with the stylesheet (if any).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceMapURL { get; set; }
		/// <summary>
		/// Gets or sets Stylesheet origin.
		/// </summary>
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or sets Stylesheet title.
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Gets or sets The backend id for the owner node of the stylesheet.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? OwnerNode { get; set; }
		/// <summary>
		/// Gets or sets Denotes whether the stylesheet is disabled.
		/// </summary>
		public bool Disabled { get; set; }
		/// <summary>
		/// Gets or sets Whether the sourceURL field value comes from the sourceURL comment.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasSourceURL { get; set; }
		/// <summary>
		/// Gets or sets Whether this stylesheet is created for STYLE tag by parser. This flag is not set for document.written STYLE tags.
		/// </summary>
		public bool IsInline { get; set; }
		/// <summary>
		/// Gets or sets Line offset of the stylesheet within the resource (zero based).
		/// </summary>
		public double StartLine { get; set; }
		/// <summary>
		/// Gets or sets Column offset of the stylesheet within the resource (zero based).
		/// </summary>
		public double StartColumn { get; set; }
		/// <summary>
		/// Gets or sets Size of the content (in characters).
		/// </summary>
		public double Length { get; set; }
	}
}
