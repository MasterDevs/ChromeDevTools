using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Represents function call argument. Either remote object id <code>objectId</code> or primitive <code>value</code> or neither of (for undefined) them should be specified.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CallArgument
	{
		/// <summary>
		/// Gets or sets Primitive value, or description string if the value can not be JSON-stringified (like NaN, Infinity, -Infinity, -0).
		/// </summary>
		public object Value { get; set; }
		/// <summary>
		/// Gets or sets Remote object handle.
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Object type.
		/// </summary>
		public string Type { get; set; }
	}
}
