using ChromeDevTools;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Fired when breakpoint is resolved to an actual script and location.
	/// </summary>
	[Event(ProtocolName.Debugger.BreakpointResolved)]
	public class BreakpointResolvedEvent
	{
		/// <summary>
		/// Gets or sets Breakpoint unique identifier.
		/// </summary>
		public string BreakpointId { get; set; }
		/// <summary>
		/// Gets or sets Actual breakpoint location.
		/// </summary>
		public Location Location { get; set; }
	}
}
