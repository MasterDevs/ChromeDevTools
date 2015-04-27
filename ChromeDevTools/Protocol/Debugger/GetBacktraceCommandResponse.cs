using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns call stack including variables changed since VM was paused. VM must be paused.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetBacktrace)]
	public class GetBacktraceCommandResponse
	{
		/// <summary>
		/// Gets or sets Call stack the virtual machine stopped on.
		/// </summary>
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		public StackTrace AsyncStackTrace { get; set; }
	}
}
