using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Information about the Frame on the page.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Frame
	{
		/// <summary>
		/// Gets or sets Frame unique identifier.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Parent frame identifier.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ParentId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the loader associated with this frame.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets Frame's name as specified in the tag.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Frame document's URL without fragment.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Frame document's URL fragment including the '#'.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UrlFragment { get; set; }
		/// <summary>
		/// Gets or sets Frame document's registered domain, taking the public suffixes list into account.
		/// Extracted from the Frame's url.
		/// Example URLs: http://www.google.com/file.html -> "google.com"
		/// http://a.b.co.uk/file.html      -> "b.co.uk"
		/// </summary>
		public string DomainAndRegistry { get; set; }
		/// <summary>
		/// Gets or sets Frame document's security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Frame document's mimeType as determined by the browser.
		/// </summary>
		public string MimeType { get; set; }
		/// <summary>
		/// Gets or sets If the frame failed to load, this contains the URL that could not be loaded. Note that unlike url above, this URL may contain a fragment.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UnreachableUrl { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether this frame was tagged as an ad and why.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AdFrameStatus AdFrameStatus { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether the main document is a secure context and explains why that is the case.
		/// </summary>
		public SecureContextType SecureContextType { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether this is a cross origin isolated context.
		/// </summary>
		public CrossOriginIsolatedContextType CrossOriginIsolatedContextType { get; set; }
		/// <summary>
		/// Gets or sets Indicated which gated APIs / features are available.
		/// </summary>
		public GatedAPIFeatures[] GatedAPIFeatures { get; set; }
	}
}
