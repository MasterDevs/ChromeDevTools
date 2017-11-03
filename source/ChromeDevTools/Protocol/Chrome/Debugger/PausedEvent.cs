using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.
	/// </summary>
	[Event(ProtocolName.Debugger.Paused)]
	[SupportedBy("Chrome")]
	public class PausedEvent
	{
		/// <summary>
		/// Gets or sets Call stack the virtual machine stopped on.
		/// </summary>
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets Pause reason.
		/// </summary>
		public string Reason { get; set; }
		/// <summary>
		/// Gets or sets Object containing break-specific auxiliary properties.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Data { get; set; }
		/// <summary>
		/// Gets or sets Hit breakpoints IDs
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] HitBreakpoints { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace AsyncStackTrace { get; set; }
	}
}
