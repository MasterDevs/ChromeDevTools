using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Asynchronous JavaScript call stack.
	/// </summary>
	public class AsyncStackTrace
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
		/// Gets or sets Next asynchronous stack trace, if any.
		/// </summary>
		[JsonProperty("asyncStackTrace")]
		public AsyncStackTrace AsyncStackTraceChild { get; set; }
	}
}
