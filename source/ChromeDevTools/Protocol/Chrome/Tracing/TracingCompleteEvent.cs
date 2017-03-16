using MasterDevs.ChromeDevTools;using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Signals that tracing is stopped and there is no trace buffers pending flush, all data were delivered via dataCollected events.
	/// </summary>
	[Event(ProtocolName.Tracing.TracingComplete)]
	[SupportedBy("Chrome")]
	public class TracingCompleteEvent
	{
	}
}
