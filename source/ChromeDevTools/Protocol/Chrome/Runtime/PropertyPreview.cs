using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	[SupportedBy("Chrome")]
	public class PropertyPreview
	{
		/// <summary>
		/// Gets or sets Property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Object type. Accessor means that the property itself is an accessor property.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets User-friendly property value string.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets Nested value preview.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ObjectPreview ValuePreview { get; set; }
		/// <summary>
		/// Gets or sets Object subtype hint. Specified for <code>object</code> type values only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Subtype { get; set; }
	}
}
