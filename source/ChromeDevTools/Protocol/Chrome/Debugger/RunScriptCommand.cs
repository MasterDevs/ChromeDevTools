using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Runs script with given id in a given context.
	/// </summary>
	[Command(ProtocolName.Debugger.RunScript)]
	[SupportedBy("Chrome")]
	public class RunScriptCommand
	{
		/// <summary>
		/// Gets or sets Id of the script to run.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets Specifies in which isolated context to perform script run. Each content script lives in an isolated context and this parameter may be used to specify one of those contexts. If the parameter is omitted or 0 the evaluation will be performed in the context of the inspected page.
		/// </summary>
		public long ExecutionContextId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		public string ObjectGroup { get; set; }
		/// <summary>
		/// Gets or sets Specifies whether script run should stop on exceptions and mute console. Overrides setPauseOnException state.
		/// </summary>
		public bool DoNotPauseOnExceptionsAndMuteConsole { get; set; }
	}
}
