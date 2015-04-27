using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns source for the script with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetScriptSource)]
	public class GetScriptSourceCommandResponse
	{
		/// <summary>
		/// Gets or sets Script source.
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
