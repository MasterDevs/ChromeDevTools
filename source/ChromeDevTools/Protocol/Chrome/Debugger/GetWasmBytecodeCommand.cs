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
	[Command(ProtocolName.Debugger.GetWasmBytecode)]
	[SupportedBy("Chrome")]
	public class GetWasmBytecodeCommand: ICommand<GetWasmBytecodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the Wasm script to get source for.
		/// </summary>
		public string ScriptId { get; set; }
	}
}
