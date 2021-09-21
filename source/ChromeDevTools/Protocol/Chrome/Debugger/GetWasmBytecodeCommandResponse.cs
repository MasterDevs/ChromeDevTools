using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// This command is deprecated. Use getScriptSource instead.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Debugger.GetWasmBytecode)]
	[SupportedBy("Chrome")]
	public class GetWasmBytecodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Script source. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string Bytecode { get; set; }
	}
}
