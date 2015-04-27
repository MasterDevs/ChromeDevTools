using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Calls function with given declaration on the given object. Object group of the result is inherited from the target object.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.CallFunctionOn)]
	public class CallFunctionOnCommandResponse
	{
		/// <summary>
		/// Gets or sets Call result.
		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets True if the result was thrown during the evaluation.
		/// </summary>
		public bool WasThrown { get; set; }
	}
}
