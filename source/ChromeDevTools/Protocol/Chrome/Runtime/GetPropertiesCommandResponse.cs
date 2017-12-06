using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Returns properties of a given object. Object group of the result is inherited from the target object.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetProperties)]
	[SupportedBy("Chrome")]
	public class GetPropertiesCommandResponse
	{
		/// <summary>
		/// Gets or sets Object properties.
		/// </summary>
		public PropertyDescriptor[] Result { get; set; }
		/// <summary>
		/// Gets or sets Internal object properties (only of the element itself).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public InternalPropertyDescriptor[] InternalProperties { get; set; }
		/// <summary>
		/// Gets or sets Exception details.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
