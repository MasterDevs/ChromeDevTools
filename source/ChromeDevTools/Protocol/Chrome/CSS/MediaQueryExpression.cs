using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Media query expression descriptor.
	/// </summary>
	[SupportedBy("Chrome")]
	public class MediaQueryExpression
	{
		/// <summary>
		/// Gets or sets Media query expression value.
		/// </summary>
		public double Value { get; set; }
		/// <summary>
		/// Gets or sets Media query expression units.
		/// </summary>
		public string Unit { get; set; }
		/// <summary>
		/// Gets or sets Media query expression feature.
		/// </summary>
		public string Feature { get; set; }
		/// <summary>
		/// Gets or sets The associated range of the value text in the enclosing stylesheet (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange ValueRange { get; set; }
		/// <summary>
		/// Gets or sets Computed length of media query expression (if applicable).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ComputedLength { get; set; }
	}
}
