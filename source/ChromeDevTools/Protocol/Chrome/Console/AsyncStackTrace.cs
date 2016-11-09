using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	/// Asynchronous JavaScript call stack.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AsyncStackTrace
	{
		/// <summary>
		/// Gets or sets Call frames of the stack trace.
		/// </summary>
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets String label of this stack trace. For async traces this may be a name of the function that initiated the async call.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets Next asynchronous stack trace, if any.
		/// </summary>
		[JsonProperty("asyncStackTrace")]
		public AsyncStackTrace AsyncStackTraceChild { get; set; }
	}
}
