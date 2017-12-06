using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Calls function with given declaration on the given object. Object group of the result is inherited from the target object.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.CallFunctionOn)]
	[SupportedBy("iOS")]
	public class CallFunctionOnCommandResponse
	{
		/// <summary>
		/// Gets or sets Call result.
		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets True if the result was thrown during the evaluation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? WasThrown { get; set; }
	}
}
