using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Compiles expression.
	/// </summary>
	[Command(ProtocolName.Runtime.CompileScript)]
	[SupportedBy("Chrome")]
	public class CompileScriptCommand: ICommand<CompileScriptCommandResponse>
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
		/// Gets or sets Specifies in which execution context to perform script run. If the parameter is omitted the evaluation will be performed in the context of the inspected page.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ExecutionContextId { get; set; }
	}
}
