using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Compiles expression.
	/// </summary>
	[Command(ProtocolName.Debugger.CompileScript)]
	[SupportedBy("Chrome")]
	public class CompileScriptCommand
	{
		/// <summary>
		/// Gets or sets Expression to compile.
		/// </summary>
		public string Expression { get; set; }
		/// <summary>
		/// Gets or sets Source url to be set for the script.
		/// </summary>
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets Specifies whether the compiled script should be persisted.
		/// </summary>
		public bool PersistScript { get; set; }
		/// <summary>
		/// Gets or sets Specifies in which isolated context to perform script run. Each content script lives in an isolated context and this parameter may be used to specify one of those contexts. If the parameter is omitted or 0 the evaluation will be performed in the context of the inspected page.
		/// </summary>
		public long ExecutionContextId { get; set; }
	}
}
