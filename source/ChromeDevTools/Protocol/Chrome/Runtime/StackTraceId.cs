using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// If `debuggerId` is set stack trace comes from another debugger and can be resolved there. This
	/// allows to track cross-debugger calls. See `Runtime.StackTrace` and `Debugger.paused` for usages.
	/// </summary>
	[SupportedBy("Chrome")]
	public class StackTraceId
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets DebuggerId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DebuggerId { get; set; }
	}
}
