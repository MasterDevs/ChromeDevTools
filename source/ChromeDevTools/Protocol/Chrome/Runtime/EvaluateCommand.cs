using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Evaluates expression on global object.
	/// </summary>
	[Command(ProtocolName.Runtime.Evaluate)]
	[SupportedBy("Chrome")]
	public class EvaluateCommand
	{
		/// <summary>
		/// Gets or sets Expression to evaluate.
		/// </summary>
		public string Expression { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
		/// <summary>
		/// Gets or sets Determines whether Command Line API should be available during the evaluation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeCommandLineAPI { get; set; }
		/// <summary>
		/// Gets or sets In silent mode exceptions thrown during evaluation are not reported and do not pause execution. Overrides <code>setPauseOnException</code> state.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Silent { get; set; }
		/// <summary>
		/// Gets or sets Specifies in which execution context to perform evaluation. If the parameter is omitted the evaluation will be performed in the context of the inspected page.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ContextId { get; set; }
		/// <summary>
		/// Gets or sets Whether the result is expected to be a JSON object that should be sent by value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReturnByValue { get; set; }
		/// <summary>
		/// Gets or sets Whether preview should be generated for the result.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
		/// <summary>
		/// Gets or sets Whether execution should be treated as initiated by user in the UI.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? UserGesture { get; set; }
		/// <summary>
		/// Gets or sets Whether execution should wait for promise to be resolved. If the result of evaluation is not a Promise, it's considered to be an error.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AwaitPromise { get; set; }
	}
}
