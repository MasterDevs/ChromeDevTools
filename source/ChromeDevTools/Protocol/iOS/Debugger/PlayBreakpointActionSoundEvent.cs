using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Fired when a "sound" breakpoint action is triggered on a breakpoint.
	/// </summary>
	[Event(ProtocolName.Debugger.PlayBreakpointActionSound)]
	[SupportedBy("iOS")]
	public class PlayBreakpointActionSoundEvent
	{
		/// <summary>
		/// Gets or sets Breakpoint action identifier.
		/// </summary>
		public long BreakpointActionId { get; set; }
	}
}
