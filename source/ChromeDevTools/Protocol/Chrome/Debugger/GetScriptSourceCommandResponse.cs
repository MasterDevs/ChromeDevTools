using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Returns source for the script with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetScriptSource)]
	[SupportedBy("Chrome")]
	public class GetScriptSourceCommandResponse
	{
		/// <summary>
		/// Gets or sets Script source (empty in case of Wasm bytecode).
		/// </summary>
		public string ScriptSource { get; set; }
		/// <summary>
		/// Gets or sets Wasm bytecode. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Bytecode { get; set; }
	}
}
