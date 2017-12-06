using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Returns displayable properties of a given object. Object group of the result is inherited from the target object. Displayable properties are own properties, internal properties, and native getters in the prototype chain (assumed to be bindings and treated like own properties for the frontend).
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetDisplayableProperties)]
	[SupportedBy("iOS")]
	public class GetDisplayablePropertiesCommandResponse
	{
		/// <summary>
		/// Gets or sets Object properties.
		/// </summary>
		public PropertyDescriptor[] Properties { get; set; }
		/// <summary>
		/// Gets or sets Internal object properties.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public InternalPropertyDescriptor[] InternalProperties { get; set; }
	}
}
