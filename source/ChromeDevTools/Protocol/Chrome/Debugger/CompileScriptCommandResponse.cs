using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Compiles expression.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.CompileScript)]
	[SupportedBy("Chrome")]
	public class CompileScriptCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the script.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets Exception details.
		/// </summary>
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
