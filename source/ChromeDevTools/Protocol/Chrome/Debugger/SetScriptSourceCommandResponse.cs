using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Edits JavaScript source live.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetScriptSource)]
	[SupportedBy("Chrome")]
	public class SetScriptSourceCommandResponse
	{
		/// <summary>
		/// Gets or sets New stack trace in case editing has happened while VM was stopped.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets VM-specific description of the changes applied.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Result { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StackTrace AsyncStackTrace { get; set; }
	}
}
