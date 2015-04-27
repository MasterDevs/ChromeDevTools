using ChromeDevTools;

namespace ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Signals that tracing is stopped and there is no trace buffers pending flush, all data were delivered via dataCollected events.
	/// </summary>
	[Event(ProtocolName.Tracing.TracingComplete)]
	public class TracingCompleteEvent
	{
	}
}
