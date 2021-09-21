using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Steps into the function call.
	/// </summary>
	[Command(ProtocolName.Debugger.StepInto)]
	[SupportedBy("Chrome")]
	public class StepIntoCommand: ICommand<StepIntoCommandResponse>
	{
		/// <summary>
		/// Gets or sets Debugger will pause on the execution of the first async task which was scheduled
		/// before next pause.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? BreakOnAsyncCall { get; set; }
		/// <summary>
		/// Gets or sets The skipList specifies location ranges that should be skipped on step into.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LocationRange[] SkipList { get; set; }
	}
}
