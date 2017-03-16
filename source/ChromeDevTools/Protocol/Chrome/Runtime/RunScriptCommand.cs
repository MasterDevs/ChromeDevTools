using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Runs script with given id in a given context.
	/// </summary>
	[Command(ProtocolName.Runtime.RunScript)]
	[SupportedBy("Chrome")]
	public class RunScriptCommand
	{
		/// <summary>
		/// Gets or sets Id of the script to run.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets Specifies in which execution context to perform script run. If the parameter is omitted the evaluation will be performed in the context of the inspected page.
		/// </summary>
		public long ExecutionContextId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		public string ObjectGroup { get; set; }
		/// <summary>
		/// Gets or sets In silent mode exceptions thrown during evaluation are not reported and do not pause execution. Overrides <code>setPauseOnException</code> state.
		/// </summary>
		public bool Silent { get; set; }
		/// <summary>
		/// Gets or sets Determines whether Command Line API should be available during the evaluation.
		/// </summary>
		public bool IncludeCommandLineAPI { get; set; }
		/// <summary>
		/// Gets or sets Whether the result is expected to be a JSON object which should be sent by value.
		/// </summary>
		public bool ReturnByValue { get; set; }
		/// <summary>
		/// Gets or sets Whether preview should be generated for the result.
		/// </summary>
		public bool GeneratePreview { get; set; }
		/// <summary>
		/// Gets or sets Whether execution should wait for promise to be resolved. If the result of evaluation is not a Promise, it's considered to be an error.
		/// </summary>
		public bool AwaitPromise { get; set; }
	}
}
