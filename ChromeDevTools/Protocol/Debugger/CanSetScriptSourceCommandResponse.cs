using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Always returns true.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.CanSetScriptSource)]
	public class CanSetScriptSourceCommandResponse
	{
		/// <summary>
		/// Gets or sets True if <code>setScriptSource</code> is supported.
		/// </summary>
		public bool Result { get; set; }
	}
}
