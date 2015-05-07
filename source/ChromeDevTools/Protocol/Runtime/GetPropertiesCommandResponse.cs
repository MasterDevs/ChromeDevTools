using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Returns properties of a given object. Object group of the result is inherited from the target object.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetProperties)]
	public class GetPropertiesCommandResponse
	{
		/// <summary>
		/// Gets or sets Object properties.
		/// </summary>
		public PropertyDescriptor[] Result { get; set; }
		/// <summary>
		/// Gets or sets Internal object properties (only of the element itself).
		/// </summary>
		public InternalPropertyDescriptor[] InternalProperties { get; set; }
	}
}
