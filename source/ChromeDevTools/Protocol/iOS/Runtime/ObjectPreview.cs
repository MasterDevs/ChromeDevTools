using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Object containing abbreviated remote object value.
	/// </summary>
	[SupportedBy("iOS")]
	public class ObjectPreview
	{
		/// <summary>
		/// Gets or sets Object type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Object subtype hint. Specified for <code>object</code> type values only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Subtype { get; set; }
		/// <summary>
		/// Gets or sets String representation of the object.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets Determines whether preview is lossless (contains all information of the original object).
		/// </summary>
		public bool Lossless { get; set; }
		/// <summary>
		/// Gets or sets True iff some of the properties of the original did not fit.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Overflow { get; set; }
		/// <summary>
		/// Gets or sets List of the properties.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PropertyPreview[] Properties { get; set; }
		/// <summary>
		/// Gets or sets List of the entries. Specified for <code>map</code> and <code>set</code> subtype values only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public EntryPreview[] Entries { get; set; }
		/// <summary>
		/// Gets or sets Size of the array/collection. Specified for array/map/set/weakmap/weakset object type values only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Size { get; set; }
	}
}
