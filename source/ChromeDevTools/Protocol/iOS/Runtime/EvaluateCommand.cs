using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Evaluates expression on global object.
	/// </summary>
	[Command(ProtocolName.Runtime.Evaluate)]
	[SupportedBy("iOS")]
	public class EvaluateCommand: ICommand<EvaluateCommandResponse>
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
		/// Gets or sets Specifies whether evaluation should stop on exceptions and mute console. Overrides setPauseOnException state.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DoNotPauseOnExceptionsAndMuteConsole { get; set; }
		/// <summary>
		/// Gets or sets Specifies in which isolated context to perform evaluation. Each content script lives in an isolated context and this parameter may be used to specify one of those contexts. If the parameter is omitted or 0 the evaluation will be performed in the context of the inspected page.
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
		/// Gets or sets Whether the resulting value should be considered for saving in the $n history.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? SaveResult { get; set; }
	}
}
