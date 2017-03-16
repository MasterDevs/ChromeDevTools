using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Object internal property descriptor. This property isn't normally visible in JavaScript code.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InternalPropertyDescriptor
	{
		/// <summary>
		/// Gets or sets Conventional property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets The value associated with the property.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RemoteObject Value { get; set; }
	}
}
