using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Restarts particular call frame from the beginning.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.RestartFrame)]
	public class RestartFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets New stack trace.
		/// </summary>
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets VM-specific description.
		/// </summary>
		public object Result { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		public StackTrace AsyncStackTrace { get; set; }
	}
}
