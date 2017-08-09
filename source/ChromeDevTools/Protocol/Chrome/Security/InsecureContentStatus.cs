using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Information about insecure content on the page.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InsecureContentStatus
	{
		/// <summary>
		/// Gets or sets True if the page was loaded over HTTPS and ran mixed (HTTP) content such as scripts.
		/// </summary>
		public bool RanMixedContent { get; set; }
		/// <summary>
		/// Gets or sets True if the page was loaded over HTTPS and displayed mixed (HTTP) content such as images.
		/// </summary>
		public bool DisplayedMixedContent { get; set; }
		/// <summary>
		/// Gets or sets True if the page was loaded over HTTPS and contained a form targeting an insecure url.
		/// </summary>
		public bool ContainedMixedForm { get; set; }
		/// <summary>
		/// Gets or sets True if the page was loaded over HTTPS without certificate errors, and ran content such as scripts that were loaded with certificate errors.
		/// </summary>
		public bool RanContentWithCertErrors { get; set; }
		/// <summary>
		/// Gets or sets True if the page was loaded over HTTPS without certificate errors, and displayed content such as images that were loaded with certificate errors.
		/// </summary>
		public bool DisplayedContentWithCertErrors { get; set; }
		/// <summary>
		/// Gets or sets Security state representing a page that ran insecure content.
		/// </summary>
		public SecurityState RanInsecureContentStyle { get; set; }
		/// <summary>
		/// Gets or sets Security state representing a page that displayed insecure content.
		/// </summary>
		public SecurityState DisplayedInsecureContentStyle { get; set; }
	}
}
