using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns <code>Promise</code> with specified ID.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetPromiseById)]
	public class GetPromiseByIdCommandResponse
	{
		/// <summary>
		/// Gets or sets Object wrapper for <code>Promise</code> with specified ID, if any.
		/// </summary>
		public Runtime.RemoteObject Promise { get; set; }
	}
}
