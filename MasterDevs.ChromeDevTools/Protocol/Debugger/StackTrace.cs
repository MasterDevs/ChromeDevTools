using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// JavaScript call stack, including async stack traces.
	/// </summary>
	public class StackTrace
	{
		/// <summary>
		/// Gets or sets Call frames of the stack trace.
		/// </summary>
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets String label of this stack trace. For async traces this may be a name of the function that initiated the async call.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		public StackTrace AsyncStackTrace { get; set; }
	}
}
