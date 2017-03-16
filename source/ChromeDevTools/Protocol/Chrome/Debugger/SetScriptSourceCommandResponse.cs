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
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets Whether current call stack  was modified after applying the changes.
		/// </summary>
		public bool StackChanged { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		public Runtime.StackTrace AsyncStackTrace { get; set; }
		/// <summary>
		/// Gets or sets Exception details if any.
		/// </summary>
		public Runtime.ExceptionDetails ExceptionDetails { get; set; }
	}
}
