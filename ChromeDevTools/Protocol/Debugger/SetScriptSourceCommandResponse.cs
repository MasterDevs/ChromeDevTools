using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Edits JavaScript source live.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetScriptSource)]
	public class SetScriptSourceCommandResponse
	{
		/// <summary>
		/// Gets or sets New stack trace in case editing has happened while VM was stopped.
		/// </summary>
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets VM-specific description of the changes applied.
		/// </summary>
		public object Result { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		public StackTrace AsyncStackTrace { get; set; }
	}
}
