using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// The pause reason auxiliary data when paused because of hitting a breakpoint.
	/// </summary>
	[SupportedBy("iOS")]
	public class BreakpointPauseReason
	{
		/// <summary>
		/// Gets or sets The identifier of the breakpoint causing the pause.
		/// </summary>
		public string BreakpointId { get; set; }
	}
}
