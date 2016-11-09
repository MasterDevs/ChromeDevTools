using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Action to perform when a breakpoint is triggered.
	/// </summary>
	[SupportedBy("iOS")]
	public class BreakpointAction
	{
		/// <summary>
		/// Gets or sets Different kinds of breakpoint actions.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Data associated with this breakpoint type (e.g. for type "eval" this is the JavaScript string to evalulate).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Data { get; set; }
		/// <summary>
		/// Gets or sets A frontend-assigned identifier for this breakpoint action.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Id { get; set; }
	}
}
