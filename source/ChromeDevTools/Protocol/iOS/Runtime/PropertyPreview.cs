using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("iOS")]
	public class PropertyPreview
	{
		/// <summary>
		/// Gets or sets Property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Object type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Object subtype hint. Specified for <code>object</code> type values only.
		/// </summary>
		public string Subtype { get; set; }
		/// <summary>
		/// Gets or sets User-friendly property value string.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets Nested value preview.
		/// </summary>
		public ObjectPreview ValuePreview { get; set; }
		/// <summary>
		/// Gets or sets True if this is an internal property.
		/// </summary>
		public bool Internal { get; set; }
	}
}
