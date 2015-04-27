using ChromeDevTools;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Fired when a set of trace logs were removed from the backend. If no parameters are given, all trace logs were removed.
	/// </summary>
	[Event(ProtocolName.Canvas.TraceLogsRemoved)]
	public class TraceLogsRemovedEvent
	{
		/// <summary>
		/// Gets or sets If given, trace logs from the given frame were removed.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets If given, trace log with the given ID was removed.
		/// </summary>
		public string TraceLogId { get; set; }
	}
}
