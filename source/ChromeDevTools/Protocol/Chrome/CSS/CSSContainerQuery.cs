using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS container query rule descriptor.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSContainerQuery
	{
		/// <summary>
		/// Gets or sets Container query text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets The associated rule header range in the enclosing stylesheet (if
		/// available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the stylesheet containing this object (if exists).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Optional name for the container.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
	}
}
