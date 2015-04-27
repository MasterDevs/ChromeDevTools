using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Runs script with given id in a given context.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.RunScript)]
	public class RunScriptCommandResponse
	{
		/// <summary>
		/// Gets or sets Run result.
		/// </summary>
		public Runtime.RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or sets Exception details.
		/// </summary>
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
