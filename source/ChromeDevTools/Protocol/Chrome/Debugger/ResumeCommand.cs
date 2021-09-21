using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Resumes JavaScript execution.
	/// </summary>
	[Command(ProtocolName.Debugger.Resume)]
	[SupportedBy("Chrome")]
	public class ResumeCommand: ICommand<ResumeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Set to true to terminate execution upon resuming execution. In contrast
		/// to Runtime.terminateExecution, this will allows to execute further
		/// JavaScript (i.e. via evaluation) until execution of the paused code
		/// is actually resumed, at which point termination is triggered.
		/// If execution is currently not paused, this parameter has no effect.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? TerminateOnResume { get; set; }
	}
}
