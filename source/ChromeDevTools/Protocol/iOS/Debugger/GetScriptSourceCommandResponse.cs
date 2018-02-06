using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Returns source for the script with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetScriptSource)]
	[SupportedBy("iOS")]
	public class GetScriptSourceCommandResponse
	{
		/// <summary>
		/// Gets or sets Script source.
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
