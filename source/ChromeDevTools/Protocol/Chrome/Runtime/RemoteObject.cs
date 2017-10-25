using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Mirror object referencing original JavaScript object.
	/// </summary>
	[SupportedBy("Chrome")]
	public class RemoteObject
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
		/// Gets or sets Object class (constructor) name. Specified for <code>object</code> type values only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ClassName { get; set; }
		/// <summary>
		/// Gets or sets Remote object value in case of primitive values or JSON values (if it was requested).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Value { get; set; }
		/// <summary>
		/// Gets or sets Primitive value which can not be JSON-stringified does not have <code>value</code>, but gets this property.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public UnserializableValue UnserializableValue { get; set; }
		/// <summary>
		/// Gets or sets String representation of the object.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets Unique object identifier (for non-primitive values).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Preview containing abbreviated property values. Specified for <code>object</code> type values only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ObjectPreview Preview { get; set; }
		/// <summary>
		/// Gets or sets CustomPreview
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CustomPreview CustomPreview { get; set; }
	}
}
