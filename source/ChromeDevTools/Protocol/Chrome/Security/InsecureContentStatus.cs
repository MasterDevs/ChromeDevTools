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
		/// Gets or sets Always false.
		/// </summary>
		public bool RanMixedContent { get; set; }
		/// <summary>
		/// Gets or sets Always false.
		/// </summary>
		public bool DisplayedMixedContent { get; set; }
		/// <summary>
		/// Gets or sets Always false.
		/// </summary>
		public bool ContainedMixedForm { get; set; }
		/// <summary>
		/// Gets or sets Always false.
		/// </summary>
		public bool RanContentWithCertErrors { get; set; }
		/// <summary>
		/// Gets or sets Always false.
		/// </summary>
		public bool DisplayedContentWithCertErrors { get; set; }
		/// <summary>
		/// Gets or sets Always set to unknown.
		/// </summary>
		public SecurityState RanInsecureContentStyle { get; set; }
		/// <summary>
		/// Gets or sets Always set to unknown.
		/// </summary>
		public SecurityState DisplayedInsecureContentStyle { get; set; }
	}
}
