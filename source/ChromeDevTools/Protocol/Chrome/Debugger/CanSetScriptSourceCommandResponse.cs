using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Always returns true.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.CanSetScriptSource)]
	[SupportedBy("Chrome")]
	public class CanSetScriptSourceCommandResponse
	{
		/// <summary>
		/// Gets or sets True if <code>setScriptSource</code> is supported.
		/// </summary>
		public bool Result { get; set; }
	}
}
