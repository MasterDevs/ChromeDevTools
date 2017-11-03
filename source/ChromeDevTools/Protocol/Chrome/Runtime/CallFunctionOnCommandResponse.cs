using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Calls function with given declaration on the given object. Object group of the result is inherited from the target object.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.CallFunctionOn)]
	[SupportedBy("Chrome")]
	public class CallFunctionOnCommandResponse
	{
		/// <summary>
		/// Gets or sets Call result.
		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets Exception details.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
