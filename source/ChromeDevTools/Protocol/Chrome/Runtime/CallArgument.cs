using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Represents function call argument. Either remote object id `objectId`, primitive `value`,
	/// unserializable primitive value or neither of (for undefined) them should be specified.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CallArgument
	{
		/// <summary>
		/// Gets or sets Primitive value or serializable javascript object.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Value { get; set; }
		/// <summary>
		/// Gets or sets Primitive value which can not be JSON-stringified.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UnserializableValue { get; set; }
		/// <summary>
		/// Gets or sets Remote object handle.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}
